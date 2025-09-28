using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CoosingForm : Form
    {
        public bool isCard;
        public Video_card video_Card;
        public cooling_sistem cooling_Sistem;
        public SelectionUC selectionUC;
        public CoosingForm(bool isCard)
        {
            InitializeComponent();
            this.isCard = isCard;
            cooling_Sistem = null;
            video_Card = null;
            selectionUC = new SelectionUC(this, isCard);
            panel_items.Controls.Add(selectionUC);
            if (isCard)
            {
                foreach (Video_card vc in Program.users[Program.currentUserIndex].video_cards)
                {
                    if (!vc.isActive)
                    {
                        selectionUC.AddCard(vc);
                    }
                }
            }
            else
            {
                foreach (cooling_sistem cs in Program.users[Program.currentUserIndex].cooling_sistems)
                {
                    if (!cs.isActive)
                    {
                        selectionUC.AddCooling(cs);
                    }
                }
            }
        }

        private void CoosingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
