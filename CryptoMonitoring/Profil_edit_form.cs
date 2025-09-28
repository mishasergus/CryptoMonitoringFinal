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
    public partial class Profil_edit_form : Form
    {
        public Profil_edit_form()
        {
            InitializeComponent();
            picture_avatar.BackgroundImage = Image.FromFile(Program.users[Program.currentUserIndex].image);
            textbox_name.Text = Program.users[Program.currentUserIndex].username;
            textbox_description.Text = Program.users[Program.currentUserIndex].description;

        }

        private void Profil_edit_form_Load(object sender, EventArgs e)
        {

        }

        private void button_brose_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose avatar img";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Program.users[Program.currentUserIndex].image = openFileDialog.FileName;
                picture_avatar.BackgroundImage = Image.FromFile(Program.users[Program.currentUserIndex].image);
                Program.SerialazeUsers();
            }
        }

        private void textbox_name_TextChanged(object sender, EventArgs e)
        {
            Program.users[Program.currentUserIndex].username = textbox_name.Text;
            Program.SerialazeUsers();
        }

        private void textbox_description_TextChanged(object sender, EventArgs e)
        {
            Program.users[Program.currentUserIndex].description = textbox_description.Text;
            Program.SerialazeUsers();
        }
    }
}
