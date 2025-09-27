using LiveChartsCore;//ліба для графіків та їх обробки
using LiveChartsCore.SkiaSharpView;//доповнення що малює графіки
using LiveChartsCore.SkiaSharpView.WinForms;//підвязка малювалки до середовища
using System;//підключка нових типів данних DateTime
using System.Collections.ObjectModel;//дає колекцію що повідомляє всім спостерігачам про свої зміни
using System.Globalization;//в деяких регіонах розподілювачем флоти иоже бути , тому ця ліба автоматом заміняє
using System.Net.Http;//надає класи для роботи з протоколом HTTP
using System.Net.WebSockets;//після отримання інфи канал не закриється
using System.Text;//ліба що зашифровує та розшифровує двійковий код
using System.Text.Json;//ліба що перетворює рядок з порередньої ліби в об'єкт JsonDocument
using System.Threading;//дає класи для роботи з потоками
using System.Threading.Tasks;//дає класи для роботи з асинхронними операціями, коли операція готова
//, програма продовжує виконанняб якщо ні, то чекає не блокуючи основний потік
using System.Windows.Forms;

namespace CryptoMonitoring
{
    public partial class Graphic : Form
    {
        // ------------------ ГЛАВНА ЧАСТИНА ------------------
        // Графік, який буде малювати ціну Бітка
        private CartesianChart priceChart;//графік

        // Тут ми будемо зберігати наші ціни для графіку
        private ObservableCollection<double> prices = new();//створення колекції що повідомляє всім
                                                            //спостерігачам про свої зміни

        // Скільки точок ми будемо показувати на графіку одночасно
        private const int MaxPoints = 500;

        // Остання ціна і час останнього оновлення
        private double minPrice = 0.0;
        private double maxPrice = 0.0;
        private double openPrice = 0.0;
        private double closePrice = 0.0;
        private double volume_sum = 0.0;
        private DateTime lastUpdate = DateTime.MinValue;

        // Мінімальний інтервал оновлення графіку і таблиці, щоб не скакало 
        private readonly TimeSpan updateInterval = TimeSpan.FromMilliseconds(60000);//оновлення раз в хвилину
        // завдяки readonly змінна стає константою після ініціалізації

        // Таблиця з торгами
        private DataGridView tradesTable;

        private string cryptoName;

        public Graphic(string cryptoName)
        {
            InitializeComponent();
            Program.AchivesOfUsers();

            this.cryptoName = cryptoName;

            // ------------------ РОЗДІЛЕНЕ ВІКНО ------------------
            // Робимо SplitContainer, щоб зліва був графік, а справа таблиця
            var split = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = 50 // для тесту графік маленький якщо хоч помніяй в іншу сторону десь до 1000
            };
            this.Controls.Add(split);

            // ------------------ ГРАФІК ------------------
            priceChart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                Series = new ISeries[]//серії даних для відображення на графіку і фільтруються
                                      //самою серією
                {
                    new LineSeries<double>//клас що відображає лінійний графік і повністю
                                          //відповідає вимогам інтерфейсу ISeries
                    {
                        Values = prices, // беремо наші ціни і завдяки тому що ми є ObservableCollection
                                         //графік буде оновлюватись автоматом без додаткового потоку
                        Fill = null, // без заливки, бо воно й так чітко виглядає
                        GeometrySize = 0, // кружечки на точках їх нам чесно нахуй не треба но хз
                        LineSmoothness = 0.8 // робимо лінію трохи плавною, щоб не скакало
                    }
                }
            };
            split.Panel1.Controls.Add(priceChart); // додаємо графік в ліву панель

            // ------------------ ТАБЛИЦЯ ------------------
            tradesTable = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,//забороняє користувачеві редагувати вміст таблиці
                AllowUserToAddRows = false//забороняє користувачеві додавати нові рядки вручну
            };
            tradesTable.Columns.Add("Time", "Час");         // Коли свічка
            tradesTable.Columns.Add("Open", "Відкриття");   // Відкриття свічки
            tradesTable.Columns.Add("High", "Макс.");       // Максимум
            tradesTable.Columns.Add("Low", "Мін.");         // Мінімум
            tradesTable.Columns.Add("Close", "Закриття");   // Закриття
            tradesTable.Columns.Add("Volume", "Обсяг");     // Обсяг торгів
            split.Panel2.Controls.Add(tradesTable); // додаємо таблицю в праву панель

            // ------------------ ІНІЦІАЛІЗАЦІЯ ------------------
            // запускаємо історію і вебсокет
            _ = InitializeData();//ти не збираєшся використовувати значення, яке повертає метод
        }

        // ------------------ ФУНКЦІЯ ІНІЦІАЛІЗАЦІЇ ------------------
        private async Task InitializeData()
        {
            // спочатку підвантажуємо свічки від часу коли я сідаю а комп(00:00) до зараз
            await LoadHistoricalData();//завантажує історичні дані з Binance API
                                       //Ключове слово await означає, що програма буде чекати
                                       //доки LoadHistoricalData() повністю не завершить свою роботу.

            // Потім підключаємо WebSocket для реального часу
            _ = ConnectWebSocket();//не чекаємо закінчення роботи ConnectWebSocket()
                                   //моніторимо данні з бінансу
        }

        // ------------------ ПІДГРУЗКА ІСТОРІЇ ------------------
        private async Task LoadHistoricalData()
        {
            var client = new HttpClient();//клас що надає запити на сервер

            // Початок дня в UTC, бо Binance працює з UTC
            DateTime todayUtc = DateTime.UtcNow.Date;//повертає поточний час
                                                     //але завдяки .Date заокруглює сек, хв і год до 0
                                                     //Тобто, отримує 00:00 UTC
            long startTime = new DateTimeOffset(todayUtc).ToUnixTimeMilliseconds();//перетворює початковий час 
                                                                                   //в Unix час в мілісекундах
                                                                                   //з 1 січня 1970 року

            // URL до Binance API, беремо максимум 1000 свічок, бо вони обмежують
            string url = $"https://api.binance.com/api/v3/klines?symbol="+ cryptoName.ToUpper() + $"USDT&interval=1m&startTime={startTime}&limit=1000";
            //"https://api.binance.com/api/v3/klines" — це базова адреса для отримання свічок
            //          (торгових даних за певний інтервал) з Binance API.
            //? — цей символ відокремлює базову адресу від параметрів запиту.
            //symbol=BTCUSDT — вказує, що ти хочеш отримати дані для торгової пари Біткоїн/Долар.
            //interval=1m — вказує, що ти хочеш отримати дані з інтервалом 1 хвилина.
            //startTime={startTime} — вказує, що ти хочеш отримати дані, починаючи з часу
            //limit=1000 — це параметр, який обмежує кількість свічок, які ти хочеш отримати





            string response = await client.GetStringAsync(url);//відправляє GET-запит на вказану URL-адресу
                                                               //і чекає на відповідь у вигляді рядка
                                                               //await означає, що програма буде чекати
                                                               //доки GetStringAsync(url) повністю не завершить свою роботу.
            var jsonDoc = JsonDocument.Parse(response);//парсить (перетворює) рядок JSON у структуру даних
                                                       //JsonDocument для подальшої обробки

            // Очистимо старі дані на всякий випадок
            tradesTable.Rows.Clear();//очищає всі рядки в таблиці
            prices.Clear();//очищає всі елементи в колекції цін

            // ------------------ ЖОСКИЙ ФОРІЧ ЯКИЙ РОБИТЬ ПРОБІГ ПО ВСІХ СВІЧКАХ ------------------
            foreach (var candle in jsonDoc.RootElement.EnumerateArray())//jsonDoc.RootElement
                                                                        //отримує кореневий елемент JSON-документа
                                                                        //.EnumerateArray() створює ітератор для перебору
                                                                        //елементів масиву JSON
            {
                // Парсимо всі числа і округляємо до одного знака після коми
                double open = Math.Round(double.Parse(candle[1].GetString(), CultureInfo.InvariantCulture), 3);
                double high = Math.Round(double.Parse(candle[2].GetString(), CultureInfo.InvariantCulture), 3);
                double low = Math.Round(double.Parse(candle[3].GetString(), CultureInfo.InvariantCulture), 3);
                double close = Math.Round(double.Parse(candle[4].GetString(), CultureInfo.InvariantCulture), 3);
                double volume = Math.Round(double.Parse(candle[5].GetString(), CultureInfo.InvariantCulture), 3);

                // ------------------ ГРАФІК ------------------
                prices.Add(close);
                if (prices.Count > MaxPoints) prices.RemoveAt(0); // тримаємо максимум точок

                // ------------------ ТАБЛИЦЯ ------------------
                long openTimeMs = candle[0].GetInt64();//беремо час відкриття свічки в мілісекундах
                DateTime openTime = DateTimeOffset.FromUnixTimeMilliseconds(openTimeMs).ToLocalTime().DateTime;
                //перетворюємо Unix час в мілісекундах в DateTime

                // Додаємо рядок зверху (нові свічки будуть вгорі)
                tradesTable.Rows.Insert(0, openTime.ToString("HH:mm"), open.ToString("F3"), high.ToString("F3"),
                    low.ToString("F3"), close.ToString("F3"), volume.ToString("F3"));//1 знак після коми
            }
        }

        // ------------------ ПІДКЛЮЧЕННЯ WEBSOCKETA ------------------
        private async Task ConnectWebSocket()
        {
            using (var ws = new ClientWebSocket())//встановлює з'єднання з веб-сокетом
            {
                Uri uri = new Uri("wss://stream.binance.com:9443/ws/"+ cryptoName.ToLower() + "usdt@trade");//URL веб-сокета Binance
                                                                                    //wss:// — це протокол WebSocket Secure,
                                                                                    //який забезпечує захищене з'єднання
                                                                                    //stream.binance.com:9443 — це доменне ім'я
                                                                                    //і порт сервера Binance для WebSocket-з'єднань
                                                                                    //ws/btcusdt@trade — це шлях до конкретного потоку даних,
                                                                                    //в даному випадку для торгів BTC/USDT
                await ws.ConnectAsync(uri, CancellationToken.None);//підключається до вказаного URI веб-сокета
                                                                   //CancellationToken.None означає,
                                                                   //що ми не використовуємо токен скасування
                var buffer = new byte[4096];//буфер для отримання даних з веб-сокета


                while (ws.State == WebSocketState.Open)//поки з'єднання відкрито
                {

                    var result = await ws.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    //очікує на отримання даних з веб-сокета
                    //отримані дані зберігаються в буфері
                    //CancellationToken.None означає, що ми не використовуємо токен скасування
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        string json = Encoding.UTF8.GetString(buffer, 0, result.Count);//перетворює отримані байти в рядок JSON
                        File.WriteAllText("last_trade.txt", json);//записує отримані дані в файл
                                                                  //для можливого подальшого аналізу
                        try
                        {
                            using (JsonDocument doc = JsonDocument.Parse(json))//парсить (перетворює) рядок JSON у структуру
                                                                               //даних JsonDocument
                            {
                                var root = doc.RootElement;//отримує кореневий елемент JSON-документа
                                string priceStr = root.GetProperty("p").GetString();
                                string volStr = root.GetProperty("q").GetString();

                                double price = Math.Round(double.Parse(priceStr, CultureInfo.InvariantCulture), 3);
                                double volume = double.Parse(volStr, CultureInfo.InvariantCulture);
                                volume_sum += volume;
                                if (minPrice == 0.0 || price < minPrice) minPrice = price;
                                if (price > maxPrice) maxPrice = price;
                                if (openPrice == 0.0) openPrice = price;

                                if ((DateTime.Now - lastUpdate) >= updateInterval)
                                {
                                    lastUpdate = DateTime.Now;
                                    closePrice = price;

                                    BeginInvoke(new Action(() =>
                                    {
                                        // ------------------ ГРАФІК ------------------
                                        prices.Add(closePrice);
                                        if (prices.Count > MaxPoints) prices.RemoveAt(0);

                                        // ------------------ ТАБЛИЦЯ ------------------
                                        tradesTable.Rows.Insert(0, DateTime.Now.ToString("HH:mm:ss"),
                                            openPrice.ToString("F3"), maxPrice.ToString("F3"), minPrice.ToString("F3"),
                                            closePrice.ToString("F3"), volume_sum.ToString("F3"));

                                        if (tradesTable.Rows.Count > 1000)
                                            tradesTable.Rows.RemoveAt(tradesTable.Rows.Count - 1);
                                        // нічого не робимо зі сокрпом шоб можна було самому гортати таблицю
                                        minPrice = 0.0;
                                        maxPrice = 0.0;
                                        openPrice = 0.0;
                                        closePrice = 0.0;
                                        volume_sum = 0.0;
                                    }));
                                }
                            }
                        }
                        catch
                        {
                            // Хуй з ним, якщо якась свічка некоректна — просто пропускаємо
                        }
                    }
                }
            }
        }



        private void Graphic_Load(object sender, EventArgs e)
        {

        }
    }
}
