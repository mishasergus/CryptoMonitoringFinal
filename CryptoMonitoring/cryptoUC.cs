using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CryptoMonitoring
{
    public partial class cryptoUC : UserControl
    {
        public cryptoUC()
        {
            InitializeComponent();
        }

        private void cryptoUC_Load(object sender, EventArgs e)
        {

        }

        public void AddCryptoButton(string cryptoName)
        {
            Button newButton = new Button();

            newButton.Text = cryptoName.ToUpper();
            newButton.Name = cryptoName;
            newButton.Font = new Font("Arial Rounded MT Bold", 13.8f, FontStyle.Regular);
            newButton.BackColor = Color.Lime;

            newButton.Size = new Size(1023, 100);

            int yPos = this.Controls.Count * (newButton.Height + 5) + 10;
            newButton.Location = new Point(10, yPos);

            newButton.Click += NewButton_Click;

            this.Controls.Add(newButton);
        }

        private void NewButton_Click(object sender, System.EventArgs e)
        {

            Button clickedButton = (Button)sender;
            Crypto_menu crypto_Menu = new Crypto_menu(clickedButton.Text);
            crypto_Menu.Show();
        }
    }
}
