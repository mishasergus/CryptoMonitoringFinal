using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CryptoMonitoring
{

    internal static class Program
    {
        public static List<User> users;
        public static int currentUserIndex;
        [STAThread]
        static void Main()
        {
            users = new List<User>();
            DeserialazeUsers();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

        public static void AchivesOfUsers()
        {
            User user = users[currentUserIndex];
            // achive 1 - earn 50.000$
            // achive 2 - first cripto buy
            // achive 3 - but bitcoin
            // achive 4 - buy eth
            // achive 5 - have 5 different cryptos
            // achive 6 - earn 200% of sell cripto
            // achive 7 - earn 1.000.000$
            // achive 8 - all achives
            if (user.balance >= 50000 && !user.achievements[0])
            {
                user.achievements[0] = true;
                MessageBox.Show("Хороший капітал!", "Ви отримали досягнення 'Хороший капітал'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (user.cryptos.Count >= 1 && !user.achievements[1])
            {
                user.achievements[1] = true;
                MessageBox.Show("Перша крипта!", "Ви отримали досягнення 'Перша крипта'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (user.cryptos.Exists(c => c.name == "Bitcoin") && !user.achievements[2])
            {
                user.achievements[2] = true;
                MessageBox.Show("Мрія зробити це в 2012 році", "Ви отримали досягнення 'Мрія зробити це в 2012 році'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (user.cryptos.Exists(c => c.name == "Ethereum") && !user.achievements[3])
            {
                user.achievements[3] = true;
                MessageBox.Show("Мрія здійснилась", "Ви отримали досягнення 'Мрія здійснилась'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (user.cryptos.Count >= 5 && !user.achievements[4])
            {
                user.achievements[4] = true;
                MessageBox.Show("Криптоколекціонер", "Ви отримали досягнення 'Криптоколекціонер'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!user.achievements[5])
            {
                // тут реалізація но тробі треба майнера зробити
            }
            if (user.balance >= 1000000 && !user.achievements[6])
            {
                user.achievements[6] = true;
                MessageBox.Show("Багатій майбутнього", "Ви отримали досягнення 'Багатій майбутнього'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!user.achievements[7])
            {
                for (int i = 0; i < 7; i++)
                {
                    if (!user.achievements[i])
                        return;
                }
                user.achievements[7] = true;
                MessageBox.Show("Криптогуру", "Ви отримали досягнення 'Криптогуру'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void SerialazeUsers()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            using (StreamWriter sw = new StreamWriter("users.json"))
            {
                sw.WriteLine(json);
            }
        }
        public static void DeserialazeUsers()
        {
            if (File.Exists("users.json"))
            {
                using (StreamReader sr = new StreamReader("users.json"))
                {
                    string json = sr.ReadToEnd();
                    users = JsonSerializer.Deserialize<List<User>>(json);
                }
            }
        }
    }
}