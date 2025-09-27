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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            string email = textbox_login.Text;
            string password = textbox_password.Text;
            bool canLogIn = false;
            foreach (User user in Program.users)
            {
                if (user.email == email && user.password == password)
                {
                    Program.currentUserIndex = Program.users.Count - 1;
                    canLogIn = true;
                    Program.currentUserIndex = Program.users.IndexOf(user);
                    Main_menu main_Menu = new Main_menu();
                    main_Menu.Show();
                    this.Close();
                }
            }
            if (!canLogIn)
            {
                MessageBox.Show("Something was wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
