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
    public partial class Main_menu : Form
    {
        cryptoUC СryptoUC;
        public Main_menu()
        {
            InitializeComponent();
            Program.AchivesOfUsers();
            СryptoUC = new cryptoUC();
            crypto_list_panel.Controls.Add(СryptoUC);
            balance.Text = $"{Program.users[Program.currentUserIndex].balance}$";
            foreach (Crypto crypto in Program.users[Program.currentUserIndex].cryptos)
            {
                СryptoUC.AddCryptoButton(crypto.name);
            }
            Profile_button.BackgroundImage = Image.FromFile(Program.users[Program.currentUserIndex].image);
        }
        private void leader_table_button_Click(object sender, EventArgs e)
        {
            tableLeaders tableLeaders = new tableLeaders();
            tableLeaders.Show();
        }

        private void chat_button_Click(object sender, EventArgs e)
        {
            Chat_form chat_Form = new Chat_form();
            chat_Form.Show();
        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            Profil_edit_form profil_Edit_Form = new Profil_edit_form();
            profil_Edit_Form.Show();
        }



        private void achivment_button_Click(object sender, EventArgs e)
        {
            AchiveMents achiveMents = new AchiveMents();
            achiveMents.Show();
        }

        private void add_crypto_button_Click(object sender, EventArgs e)
        {
            Add_crypto_form add_Crypto_Form = new Add_crypto_form(СryptoUC);
            add_Crypto_Form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            balance.Text = $"{Program.users[Program.currentUserIndex].balance}$";
            Profile_button.BackgroundImage = Image.FromFile(Program.users[Program.currentUserIndex].image);
        }

        private void shop_button_Click(object sender, EventArgs e)
        {

        }

        private void crypto_farm_button_Click(object sender, EventArgs e)
        {
            Crypto_farm crypto_Farm = new Crypto_farm();
            crypto_Farm.Show();
        }
    }
}
