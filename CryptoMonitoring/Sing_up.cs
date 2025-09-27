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
    public partial class Sing_up : Form
    {
        public Sing_up()
        {
            InitializeComponent();
        }

        private void button_sing_up_Click(object sender, EventArgs e)
        {
            string name = textbox_username.Text;
            string email = textbox_login.Text;
            string password = textbox_password.Text;
            bool canBeCreated = true;
            foreach (User user in Program.users)
            {
                if (user.email == email)
                {
                    MessageBox.Show("This email is already taken", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    canBeCreated = false;
                }
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                canBeCreated = false;
            }
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;
            foreach (char simv in password)
            { 
                if (char.IsUpper(simv)) hasUpper = true;
                else if (char.IsLower(simv)) hasLower = true;
                else if (char.IsDigit(simv)) hasDigit = true;
                else if (!char.IsLetterOrDigit(simv)) hasSpecial = true;
            }
            if (!hasUpper) {
                devil_lable.ForeColor = Color.Lime;
                devil_lable.Text = "Password must contain at least one uppercase letter";
                canBeCreated = false;
            }
            else if (!hasLower)
            {
                devil_lable.ForeColor = Color.Lime;
                devil_lable.Text = "Password must contain at least one lowercase letter";
                canBeCreated = false;
            }
            else if (!hasDigit)
            {
                devil_lable.ForeColor = Color.Lime;
                devil_lable.Text = "Password must contain at least one digit";
                canBeCreated = false;
            }
            else if (!hasSpecial)
            {
                devil_lable.ForeColor = Color.Lime;
                devil_lable.Text = "Password must contain at least one special character";
                canBeCreated = false;
            }
            else if(canBeCreated)
            {
                devil_lable.ForeColor = Color.Black;
                devil_lable.Text = "ffg";
            }
            if (canBeCreated)
            {
                User user = new User(name, email, password);
                Program.users.Add(user);
                Program.SerialazeUsers();
                Program.currentUserIndex = Program.users.Count - 1;
                Main_menu main_Menu = new Main_menu();
                main_Menu.Show();
                this.Close();
            }
        }
    }
}
