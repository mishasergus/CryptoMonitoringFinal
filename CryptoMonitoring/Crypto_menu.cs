using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;//підключка нових типів данних DateTime
using System.Collections.ObjectModel;//дає колекцію що повідомляє всім спостерігачам про свої зміни
using System.Net.Http;//надає класи для роботи з протоколом HTTP
using System.Net.WebSockets;//після отримання інфи канал не закриється

namespace CryptoMonitoring
{
    public partial class Crypto_menu : Form
    {
        private string cryptoName;

        private double priceOfCrypto;
        public Crypto_menu(string cryptoName)
        {
            InitializeComponent();
            Program.AchivesOfUsers();
            this.cryptoName = cryptoName;
            label_crypto1.Text = cryptoName;
            label_crypto2.Text = cryptoName;
            updateBalance();
            _ = getPriceOfCrypto();
        }

        private void Crypto_menu_Load(object sender, EventArgs e)
        {

        }

        private async Task getPriceOfCrypto()
        {
            using (var client = new HttpClient())
            {

                string url = $"https://api.binance.com/api/v3/ticker/price?symbol=" + cryptoName.ToUpper() + $"USDT";
                try
                {
                    string response = await client.GetStringAsync(url);//відправляє GET-запит на вказану URL-адресу
                                                                       //і чекає на відповідь у вигляді рядка
                                                                       //await означає, що програма буде чекати
                                                                       //доки GetStringAsync(url) повністю не завершить свою роботу.
                    var jsonDoc = JsonDocument.Parse(response);//парсить (перетворює) рядок JSON у структуру даних
                                                               //JsonDocument для подальшої обробки

                    var candle = jsonDoc.RootElement;

                    priceOfCrypto = Math.Round(double.Parse(candle.GetProperty("price").GetString(), CultureInfo.InvariantCulture), 3);

                    curse_label.Text = priceOfCrypto.ToString() + "USDT = 1" + cryptoName;
                }
                catch
                {

                }
            }
        }

        private void button_graphic_Click(object sender, EventArgs e)
        {
            Graphic graphic = new Graphic(cryptoName);
            graphic.Show();
        }

        private void textbox_USDT1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (priceOfCrypto == 0)
                {
                    priceOfCrypto = 0.00001;
                }
                double usdt = double.Parse(textbox_USDT1.Text);
                if (usdt < 0)
                {
                    usdt = 0;
                }
                if (Program.users[Program.currentUserIndex].balance < usdt)
                {
                    usdt = Program.users[Program.currentUserIndex].balance;
                    textbox_USDT1.Text = usdt.ToString();
                }
                double crypto = Math.Round(usdt / priceOfCrypto, 5);
                textbox_crypto1.Text = crypto.ToString("F5");
            }
            catch
            {

            }
        }

        private void textbox_crypto2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double crypto = double.Parse(textbox_crypto2.Text);
                if (crypto < 0)
                {
                    crypto = 0;
                }
                foreach (Crypto c in Program.users[Program.currentUserIndex].cryptos)
                {
                    if (c.name == cryptoName)
                    {
                        if (c.count < crypto)
                        {
                            crypto = c.count;
                            textbox_crypto2.Text = crypto.ToString();
                        }
                        break;
                    }
                }
                double usdt = Math.Round(crypto * priceOfCrypto, 5);
                textbox_USDT2.Text = usdt.ToString("F5");
            }
            catch
            {
                
            }
        }

        private void USDT_to_crypto_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (priceOfCrypto == 0)
                {
                    priceOfCrypto = 0.00001;
                }
                double usdt = double.Parse(textbox_USDT1.Text);
                if (Program.users[Program.currentUserIndex].balance < usdt)
                {
                    MessageBox.Show("No money", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (usdt < 0)
                    {
                        usdt = 0;
                    }
                    double crypto = Math.Round(usdt / priceOfCrypto, 5);
                    Program.users[Program.currentUserIndex].balance -= usdt;
                    Program.users[Program.currentUserIndex].balance = Math.Round(Program.users[Program.currentUserIndex].balance, 5);
                    foreach (Crypto c in Program.users[Program.currentUserIndex].cryptos)
                    {
                        if (c.name == cryptoName)
                        {
                            c.count += crypto;
                            c.count = Math.Round(c.count, 5);
                            break;
                        }
                    }
                    Program.SerialazeUsers();
                }


            }
            catch
            {

            }
        }
        private void updateBalance()
        {
            foreach (Crypto c in Program.users[Program.currentUserIndex].cryptos)
            {
                if (c.name == cryptoName)
                {
                    label_balance.Text = $"{Program.users[Program.currentUserIndex].balance}$|{c.count}{cryptoName}";
                    break;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateBalance();
            _ = getPriceOfCrypto();
        }

        private void crypto_to_USRT_button2_Click(object sender, EventArgs e)
        {
            try
            {
                double crypto = double.Parse(textbox_crypto2.Text);
                foreach (Crypto c in Program.users[Program.currentUserIndex].cryptos)
                {
                    if (c.name == cryptoName) {
                        if (c.count < crypto)
                        {
                            MessageBox.Show("No crypto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (crypto < 0)
                            {
                                crypto = 0;
                            }
                            double usdt = Math.Round(crypto * priceOfCrypto, 5);
                            c.count -= crypto;
                            c.count = Math.Round(c.count, 5);
                            Program.users[Program.currentUserIndex].balance += usdt;
                            Program.users[Program.currentUserIndex].balance = Math.Round(Program.users[Program.currentUserIndex].balance, 5);
                            Program.SerialazeUsers();
                        }
                    }
                }


            }
            catch
            {

            }
        }
    }
}
