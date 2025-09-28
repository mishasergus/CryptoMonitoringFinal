using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace CryptoMonitoring
{
    public partial class Chat_form : Form
    {
        ChatUC chatUC;
        public Chat_form()
        {
            InitializeComponent();
            chatUC = new ChatUC();
            chat_pannel.Controls.Add(chatUC);
            using (SqlConnection connectoin = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ITSTEP\\C#\\CryptoMonitoring-Tests-master\\CryptoMonitoring\\Chat_db.mdf;Integrated Security=True"))
            {
                connectoin.Open();
                string sql = "SELECT * FROM Masseges";
                SqlCommand command = new SqlCommand(sql, connectoin);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Program.id_counter = (int)reader["Id"];
                    chatUC.AddMassege($"{reader["Massege"]}", $"{reader["MailOfSender"]}");
                }
            }
        }

        private void seng_button_Click(object sender, EventArgs e)
        {
            chatUC.AddMassege(textbox_massege.Text, Program.users[Program.currentUserIndex].email);
            using (SqlConnection connectoin = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ITSTEP\\C#\\CryptoMonitoring-Tests-master\\CryptoMonitoring\\Chat_db.mdf;Integrated Security=True"))
            {
                connectoin.Open();
                Console.WriteLine("Connected");
                string sql = "INSERT INTO Masseges (MailOfSender, Massege, Id) VALUES (@MailOfSender, @Massege, @Id)";
                SqlCommand command = new SqlCommand(sql, connectoin);
                command.Parameters.AddWithValue("@MailOfSender", Program.users[Program.currentUserIndex].email);
                command.Parameters.AddWithValue("@Massege", textbox_massege.Text);
                command.Parameters.AddWithValue("@Id", ++Program.id_counter);
                int rows = command.ExecuteNonQuery();//запускає всі зміни
            }
        }
    }
}
