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
    public partial class SelectionUC : UserControl
    {
        CoosingForm coosingForm;
        bool isCard;
        public SelectionUC(CoosingForm coosingForm, bool isCard)
        {
            InitializeComponent();
            this.coosingForm = coosingForm;
            this.isCard = isCard;
        }

        private void SelectionUC_Load(object sender, EventArgs e)
        {

        }
        public void AddCard(Video_card card)
        {
            Button newButton = new Button();


            newButton.FlatStyle = FlatStyle.Popup;
            newButton.BackColor = Color.Black;
            newButton.Tag = card;
            newButton.FlatStyle = FlatStyle.Standard;
            newButton.Font = new Font("Arial Rounded MT Bold", 13.8f, FontStyle.Regular);
            newButton.ForeColor = Color.Lime;
            newButton.TextImageRelation = TextImageRelation.ImageAboveText;
            newButton.Text = card.strength.ToString() + "/5000";
            int level = card.level;
            switch (level)
            {
                case 1:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_grey_img.png");
                    break;
                case 2:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_green_img.png");
                    break;
                case 3:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_orange_img.png");
                    break;
                case 4:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_blue_img.png");
                    break;
                case 5:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_purple_img.png");
                    break;
                default:
                    break;
            }
            newButton.Size = new Size(100, 100);

            int yPos = this.Controls.Count * (newButton.Height + 5) + 10;
            newButton.Location = new Point(10, yPos);

            newButton.Click += ButClick;

            this.Controls.Add(newButton);
        }
        public void AddCooling(cooling_sistem sist)
        {
            Button newButton = new Button();


            newButton.FlatStyle = FlatStyle.Popup;
            newButton.BackColor = Color.Black;
            newButton.Tag = sist;
            newButton.FlatStyle = FlatStyle.Standard;
            newButton.Font = new Font("Arial Rounded MT Bold", 13.8f, FontStyle.Regular);
            newButton.ForeColor = Color.Lime;
            newButton.TextImageRelation = TextImageRelation.ImageAboveText;
            newButton.Text = sist.cooling_power.ToString() + "/25";
            int level = sist.level;
            switch (level)
            {
                case 1:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\cooling_system_grey_img.png");
                    break;
                case 2:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\cooling_system_green_img.png");
                    break;
                case 3:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\cooling_system_orange_img.png");
                    break;
                case 4:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\cooling_system_blue_img.png");
                    break;
                case 5:
                    newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\cooling_system_purple_img.png");
                    break;
                default:
                    break;
            }
            newButton.Size = new Size(100, 100);

            int yPos = this.Controls.Count * (newButton.Height + 5) + 10;
            newButton.Location = new Point(10, yPos);

            newButton.Click += ButClick;

            this.Controls.Add(newButton);
        }
        private void ButClick(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (isCard)
            {
                coosingForm.video_Card = (Video_card)clickedButton.Tag;
            }
            else if(!isCard)
            {
                coosingForm.cooling_Sistem = (cooling_sistem)clickedButton.Tag;
            }
            coosingForm.DialogResult = DialogResult.OK;
            coosingForm.Close();
        }
    }
}
