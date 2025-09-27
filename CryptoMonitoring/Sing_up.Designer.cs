namespace CryptoMonitoring
{
    partial class Sing_up
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
            button_sing_up = new Button();
            textbox_username = new TextBox();
            label_username = new Label();
            label_login = new Label();
            textbox_login = new TextBox();
            label_password = new Label();
            textbox_password = new TextBox();
            devil_text = new Label();
            devil_lable = new Label();
            SuspendLayout();
            // 
            // logo
            // 
            logo.FlatStyle = FlatStyle.Popup;
            logo.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.Lime;
            logo.Image = Properties.Resources.banan_logo_img;
            logo.ImageAlign = ContentAlignment.MiddleLeft;
            logo.Location = new Point(14, 3);
            logo.Name = "logo";
            logo.Size = new Size(317, 103);
            logo.TabIndex = 4;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // button_sing_up
            // 
            button_sing_up.BackColor = Color.Lime;
            button_sing_up.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button_sing_up.FlatAppearance.BorderSize = 0;
            button_sing_up.FlatStyle = FlatStyle.Flat;
            button_sing_up.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_sing_up.ForeColor = Color.Black;
            button_sing_up.Location = new Point(147, 346);
            button_sing_up.Name = "button_sing_up";
            button_sing_up.Size = new Size(206, 48);
            button_sing_up.TabIndex = 3;
            button_sing_up.Text = "Sing up";
            button_sing_up.UseVisualStyleBackColor = false;
            button_sing_up.Click += button_sing_up_Click;
            // 
            // textbox_username
            // 
            textbox_username.BackColor = SystemColors.InactiveCaptionText;
            textbox_username.BorderStyle = BorderStyle.None;
            textbox_username.Cursor = Cursors.IBeam;
            textbox_username.Font = new Font("Arial Rounded MT Bold", 12F);
            textbox_username.ForeColor = Color.Lime;
            textbox_username.Location = new Point(147, 139);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(206, 24);
            textbox_username.TabIndex = 5;
            textbox_username.Text = "-";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_username.ForeColor = Color.Lime;
            label_username.Location = new Point(147, 109);
            label_username.Name = "label_username";
            label_username.Size = new Size(134, 27);
            label_username.TabIndex = 6;
            label_username.Text = "Username:";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_login.ForeColor = Color.Lime;
            label_login.Location = new Point(147, 166);
            label_login.Name = "label_login";
            label_login.Size = new Size(81, 27);
            label_login.TabIndex = 8;
            label_login.Text = "Login:";
            // 
            // textbox_login
            // 
            textbox_login.BackColor = SystemColors.InactiveCaptionText;
            textbox_login.BorderStyle = BorderStyle.None;
            textbox_login.Cursor = Cursors.IBeam;
            textbox_login.Font = new Font("Arial Rounded MT Bold", 12F);
            textbox_login.ForeColor = Color.Lime;
            textbox_login.Location = new Point(147, 196);
            textbox_login.Name = "textbox_login";
            textbox_login.Size = new Size(206, 24);
            textbox_login.TabIndex = 7;
            textbox_login.Text = "-";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_password.ForeColor = Color.Lime;
            label_password.Location = new Point(147, 230);
            label_password.Name = "label_password";
            label_password.Size = new Size(129, 27);
            label_password.TabIndex = 10;
            label_password.Text = "Password:";
            // 
            // textbox_password
            // 
            textbox_password.BackColor = SystemColors.InactiveCaptionText;
            textbox_password.BorderStyle = BorderStyle.None;
            textbox_password.Cursor = Cursors.IBeam;
            textbox_password.Font = new Font("Arial Rounded MT Bold", 12F);
            textbox_password.ForeColor = Color.Lime;
            textbox_password.Location = new Point(147, 260);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.Size = new Size(206, 24);
            textbox_password.TabIndex = 9;
            textbox_password.Text = "-";
            // 
            // devil_text
            // 
            devil_text.AutoSize = true;
            devil_text.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            devil_text.ForeColor = Color.Lime;
            devil_text.Location = new Point(152, 287);
            devil_text.Name = "devil_text";
            devil_text.Size = new Size(0, 20);
            devil_text.TabIndex = 11;
            // 
            // devil_lable
            // 
            devil_lable.AutoSize = true;
            devil_lable.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            devil_lable.Location = new Point(147, 287);
            devil_lable.Name = "devil_lable";
            devil_lable.Size = new Size(60, 20);
            devil_lable.TabIndex = 12;
            devil_lable.Text = "label1";
            // 
            // Sing_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(489, 450);
            Controls.Add(devil_lable);
            Controls.Add(devil_text);
            Controls.Add(label_password);
            Controls.Add(textbox_password);
            Controls.Add(label_login);
            Controls.Add(textbox_login);
            Controls.Add(label_username);
            Controls.Add(textbox_username);
            Controls.Add(logo);
            Controls.Add(button_sing_up);
            Name = "Sing_up";
            Text = "Sing_up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logo;
        private Button button_sing_up;
        private TextBox textbox_username;
        private Label label_username;
        private Label label_login;
        private TextBox textbox_login;
        private Label label_password;
        private TextBox textbox_password;
        private Label devil_text;
        private Label devil_lable;
    }
}