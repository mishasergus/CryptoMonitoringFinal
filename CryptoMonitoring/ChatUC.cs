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
    public partial class ChatUC : UserControl
    {
        public ChatUC()
        {
            InitializeComponent();
        }

        private void ChatUC_Load(object sender, EventArgs e)
        {

        }

        public void AddMassege(string massege, string email)
        {
            Button newButton = new Button();

            foreach (User u in Program.users)
            {
                if (u.email == email)
                {
                    newButton.Image = Image.FromFile(u.image);
                    newButton.Text = u.username + ": " + massege;
                    break;
                }
            }
            newButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newButton.FlatStyle = FlatStyle.Popup;
            newButton.BackColor = Color.Black;
            newButton.Name = email;
            newButton.Font = new Font("Arial Rounded MT Bold", 13.8f, FontStyle.Regular);
            newButton.ForeColor = Color.Lime;
            newButton.ImageAlign = ContentAlignment.MiddleLeft;

            newButton.Size = new Size(330, 40);

            int yPos = this.Controls.Count * (newButton.Height + 5) + 10;
            newButton.Location = new Point(10, yPos);

            newButton.Click += MessageClick;

            this.Controls.Add(newButton);
        }
        private void MessageClick(object sender, System.EventArgs e)
        {

            Button clickedButton = (Button)sender;
            Profile_spectator profile_Spectator = new Profile_spectator(clickedButton.Name);
            profile_Spectator.Show();
        }
    }
}
