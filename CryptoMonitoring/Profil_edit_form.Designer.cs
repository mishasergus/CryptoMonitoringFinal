namespace CryptoMonitoring
{
    partial class Profil_edit_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logo = new Button();
            picture_avatar = new PictureBox();
            button_brose_img = new Button();
            ((System.ComponentModel.ISupportInitialize)picture_avatar).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.FlatStyle = FlatStyle.Popup;
            logo.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.Lime;
            logo.Image = Properties.Resources.banan_logo_img;
            logo.ImageAlign = ContentAlignment.MiddleLeft;
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(314, 103);
            logo.TabIndex = 4;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // picture_avatar
            // 
            picture_avatar.BackgroundImageLayout = ImageLayout.Stretch;
            picture_avatar.Location = new Point(12, 138);
            picture_avatar.Name = "picture_avatar";
            picture_avatar.Size = new Size(95, 84);
            picture_avatar.TabIndex = 5;
            picture_avatar.TabStop = false;
            // 
            // button_brose_img
            // 
            button_brose_img.BackColor = Color.Lime;
            button_brose_img.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button_brose_img.FlatAppearance.BorderSize = 0;
            button_brose_img.FlatStyle = FlatStyle.Flat;
            button_brose_img.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_brose_img.ForeColor = Color.Black;
            button_brose_img.Location = new Point(161, 154);
            button_brose_img.Name = "button_brose_img";
            button_brose_img.Size = new Size(131, 47);
            button_brose_img.TabIndex = 14;
            button_brose_img.Text = "Brose";
            button_brose_img.UseVisualStyleBackColor = false;
            button_brose_img.Click += button_brose_img_Click;
            // 
            // Profil_edit_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(333, 494);
            Controls.Add(button_brose_img);
            Controls.Add(picture_avatar);
            Controls.Add(logo);
            Name = "Profil_edit_form";
            Text = "Profil_edit_form";
            Load += Profil_edit_form_Load;
            ((System.ComponentModel.ISupportInitialize)picture_avatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logo;
        private PictureBox picture_avatar;
        private Button button_brose_img;
    }
}