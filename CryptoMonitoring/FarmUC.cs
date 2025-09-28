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
    public partial class FarmUC : UserControl
    {
        public FarmUC()
        {
            InitializeComponent();
        }

        private void FarmUC_Load(object sender, EventArgs e)
        {

        }
        public void AddCard()
        {
            Button newButton = new Button();


            newButton.FlatStyle = FlatStyle.Popup;
            newButton.BackColor = Color.Black;
            newButton.Name = "Noname";
            newButton.FlatStyle = FlatStyle.Standard;
            newButton.Font = new Font("Arial Rounded MT Bold", 13.8f, FontStyle.Regular);
            newButton.ForeColor = Color.Lime;
            newButton.TextImageRelation = TextImageRelation.ImageAboveText;
            newButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\plus_img.png");
            newButton.Size = new Size(100, 100);
            int yPos = (int)(this.Controls.Count / 6) * (newButton.Height + 5);
            int xPos = (this.Controls.Count % 6) * (newButton.Width + 5) + 10;
            newButton.Location = new Point(xPos, yPos);
            newButton.Click += ButClick;

            this.Controls.Add(newButton);
        }
        public void AddCard(Video_card card)
        {
            Button newButton = new Button();


            newButton.FlatStyle = FlatStyle.Popup;
            newButton.BackColor = Color.Black;
            newButton.Name = "Card";
            newButton.FlatStyle = FlatStyle.Standard;
            newButton.Font = new Font("Arial Rounded MT Bold", 13.8f, FontStyle.Regular);
            newButton.ForeColor = Color.Lime;
            newButton.TextImageRelation = TextImageRelation.ImageAboveText;
            switch (card.level)
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
            newButton.Text = card.strength.ToString() + "/5000";
            newButton.Tag = card;
            newButton.Size = new Size(100, 100);

            newButton.Click += ButClick;

            this.Controls.Add(newButton);
        }
        private void ButClick(object sender, System.EventArgs e)
        {

            Button clickedButton = (Button)sender;
            bool er = false;
            using (CoosingForm selectionDialog = new CoosingForm(true))
            {
                DialogResult result = selectionDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    
                    Video_card selectedCard = selectionDialog.video_Card;
                    selectedCard.isActive = true;
                    switch (selectedCard.level)
                    {
                        case 1:
                            clickedButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_grey_img.png");
                            break;
                        case 2:
                            clickedButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_green_img.png");
                            break;
                        case 3:
                            clickedButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_orange_img.png");
                            break;
                        case 4:
                            clickedButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_blue_img.png");
                            break;
                        case 5:
                            clickedButton.Image = Image.FromFile("C:\\Users\\User\\Downloads\\video_card_purple_img.png");
                            break;
                        default:
                            break;
                    }
                    clickedButton.Text = selectedCard.strength.ToString() + "/5000";
                    clickedButton.Tag = selectedCard;
                    
                }
                else
                {
                    er = true;
                }
            }
            if (clickedButton.Name == "Noname" && !er)
            {
                clickedButton.Name = "Card";
                AddCard();
            }
        }
    }
}
