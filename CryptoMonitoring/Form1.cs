namespace CryptoMonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sing_up_Click(object sender, EventArgs e)
        {
            Sing_up sing_Up = new Sing_up();
            sing_Up.Show();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            Log_in log_In = new Log_in();
            log_In.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
