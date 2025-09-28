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
            label_name = new Label();
            textbox_name = new TextBox();
            label1 = new Label();
            textbox_description = new TextBox();
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
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_name.ForeColor = Color.Lime;
            label_name.Location = new Point(12, 264);
            label_name.Name = "label_name";
            label_name.Size = new Size(84, 27);
            label_name.TabIndex = 18;
            label_name.Text = "Name:";
            // 
            // textbox_name
            // 
            textbox_name.BackColor = SystemColors.InactiveCaptionText;
            textbox_name.BorderStyle = BorderStyle.None;
            textbox_name.Cursor = Cursors.IBeam;
            textbox_name.Font = new Font("Arial Rounded MT Bold", 12F);
            textbox_name.ForeColor = Color.Lime;
            textbox_name.Location = new Point(115, 267);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(206, 24);
            textbox_name.TabIndex = 17;
            textbox_name.Text = "-";
            textbox_name.TextChanged += textbox_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(12, 307);
            label1.Name = "label1";
            label1.Size = new Size(148, 27);
            label1.TabIndex = 20;
            label1.Text = "Description:";
            // 
            // textbox_description
            // 
            textbox_description.BackColor = SystemColors.InactiveCaptionText;
            textbox_description.BorderStyle = BorderStyle.None;
            textbox_description.Cursor = Cursors.IBeam;
            textbox_description.Font = new Font("Arial Rounded MT Bold", 12F);
            textbox_description.ForeColor = Color.Lime;
            textbox_description.Location = new Point(161, 310);
            textbox_description.Multiline = true;
            textbox_description.Name = "textbox_description";
            textbox_description.Size = new Size(160, 172);
            textbox_description.TabIndex = 19;
            textbox_description.Text = "-";
            textbox_description.TextChanged += textbox_description_TextChanged;
            // 
            // Profil_edit_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(333, 494);
            Controls.Add(label1);
            Controls.Add(textbox_description);
            Controls.Add(label_name);
            Controls.Add(textbox_name);
            Controls.Add(button_brose_img);
            Controls.Add(picture_avatar);
            Controls.Add(logo);
            Name = "Profil_edit_form";
            Text = "Profil_edit_form";
            Load += Profil_edit_form_Load;
            ((System.ComponentModel.ISupportInitialize)picture_avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logo;
        private PictureBox picture_avatar;
        private Button button_brose_img;
        private Label label_name;
        private TextBox textbox_name;
        private Label label1;
        private TextBox textbox_description;
    }
}