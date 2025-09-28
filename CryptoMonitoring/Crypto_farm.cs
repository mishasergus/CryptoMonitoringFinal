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
    public partial class Crypto_farm : Form
    {
        FarmUC farmUC;
        public Crypto_farm()
        {
            InitializeComponent();
            farmUC = new FarmUC();
            panel_cards.Controls.Add(farmUC);
            foreach (Video_card vc in Program.users[Program.currentUserIndex].video_cards)
            {
                if (vc.isActive)
                {
                    farmUC.AddCard(vc);
                }
            }
            farmUC.AddCard();

        }

        private void Crypto_farm_Load(object sender, EventArgs e)
        {

        }
    }
}
