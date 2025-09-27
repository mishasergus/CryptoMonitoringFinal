using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMonitoring
{
    public partial class Add_crypto_form : Form
    {
        cryptoUC СryptoUC;
        public Add_crypto_form(cryptoUC СryptoUC)
        {
            this.СryptoUC = СryptoUC;
            InitializeComponent();
        }

        private async void button_submit_Click(object sender, EventArgs e)
        {
            foreach (Crypto crypto in Program.users[Program.currentUserIndex].cryptos)
            {
                if (crypto.name == textbox_indificaton.Text.ToUpper())
                {
                    MessageBox.Show("You already have this crypto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string cryptoName = textbox_indificaton.Text;

            bool isValid1 = await UrlChecker.IsValidHttpUrlAsync(cryptoName);
            bool isValid2 = await UrlChecker.IsValidWebSocketUrlAsync(cryptoName);
            if (isValid1 && isValid2)
            {
                Crypto crypto = new Crypto(cryptoName.ToUpper(), 0);
                Program.users[Program.currentUserIndex].cryptos.Add(crypto);
                Program.SerialazeUsers();
                СryptoUC.AddCryptoButton(cryptoName);
                Program.AchivesOfUsers();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Add_crypto_form_Load(object sender, EventArgs e)
        {

        }
    }
}
