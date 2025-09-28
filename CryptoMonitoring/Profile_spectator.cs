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
    public partial class Profile_spectator : Form
    {
        public Profile_spectator(string email)
        {
            InitializeComponent();
            foreach (User u in Program.users)
            {
                if (u.email == email)
                {
                    picture_avatar.Image = Image.FromFile(u.image);
                    label_name.Text = "Name: " + u.username;
                    label_description.Text = "Description: " + u.description;
                    label_balance.Text = $"Balance: {u.balance}$";
                    break;
                }
            }
        }

        private void Profile_spectator_Load(object sender, EventArgs e)
        {

        }
    }
}
