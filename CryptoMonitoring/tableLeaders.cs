using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CryptoMonitoring
{
    public partial class tableLeaders : Form
    {
        public tableLeaders()
        {
            InitializeComponent();
        }

        private void tableLeaders_Load(object sender, EventArgs e)
        {
            dataGridViewLeaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLeaders.ReadOnly = true;
            dataGridViewLeaders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLeaders.BackgroundColor = Color.Black;
            dataGridViewLeaders.ForeColor = Color.Lime;
            dataGridViewLeaders.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewLeaders.ColumnHeadersDefaultCellStyle.ForeColor = Color.Lime;
            dataGridViewLeaders.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 10.8f, FontStyle.Regular);
            dataGridViewLeaders.EnableHeadersVisualStyles = false;
            dataGridViewLeaders.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewLeaders.DefaultCellStyle.ForeColor = Color.Lime;
            dataGridViewLeaders.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 10.8f, FontStyle.Regular);
            var sortedUsers = Program.users.OrderByDescending(u => u.balance).ToList();

            dataGridViewLeaders.Columns.Clear();
            dataGridViewLeaders.Rows.Clear();
            dataGridViewLeaders.AutoGenerateColumns = false;
            dataGridViewLeaders.AllowUserToAddRows = false;

            dataGridViewLeaders.Columns.Add("Rank", "№");
            dataGridViewLeaders.Columns.Add("Username", "Ім'я користувача");
            dataGridViewLeaders.Columns.Add("Balance", "Баланс $");

            int rank = 1;
            foreach (var user in sortedUsers)
            {
                dataGridViewLeaders.Rows.Add(rank, user.username, user.balance.ToString("F2"));
                rank++;
            }
        }

        private void dataGridViewLeaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
