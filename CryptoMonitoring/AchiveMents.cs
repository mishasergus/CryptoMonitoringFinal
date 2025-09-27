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
    public partial class AchiveMents : Form
    {
        public AchiveMents()
        {
            InitializeComponent();
            Program.AchivesOfUsers();
        }

        private void AchiveMents_Load(object sender, EventArgs e)
        {
            // Досягнення
            // Хороший капітал - нафармити 50.000$
            // Перша крипта - купити першу криптовалюту
            // Мрія зробити це в 2012 році - купити Bitcoin
            // Мрія здійснилась - купити Ethereum
            // Майнер - купити перший майнер
            User user = Program.users[Program.currentUserIndex];
            if (user.achievements[0])
            {
                isaprove1.BackgroundImage = Properties.Resources.approved;
                isaprove1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (user.achievements[1])
            {
                isaprove2.BackgroundImage = Properties.Resources.approved;
                isaprove2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (user.achievements[2])
            {
                isaprove3.BackgroundImage = Properties.Resources.approved;
                isaprove3.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (user.achievements[3])
            {
                isaprove4.BackgroundImage = Properties.Resources.approved;
                isaprove4.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (user.achievements[4])
            {
                isaprove5.BackgroundImage = Properties.Resources.approved;
                isaprove5.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (user.achievements[5])
            {
                isaprove6.BackgroundImage = Properties.Resources.approved;
                isaprove6.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (user.achievements[6])
            {
                isaprove7.BackgroundImage = Properties.Resources.approved;
                isaprove7.BackgroundImageLayout = ImageLayout.Zoom;
            }
            if (user.achievements[7])
            {
                isaprove8.BackgroundImage = Properties.Resources.approved;
                isaprove8.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
