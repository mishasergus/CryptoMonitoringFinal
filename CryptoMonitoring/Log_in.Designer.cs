namespace CryptoMonitoring
{
    partial class Log_in
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
            devil_lable = new Label();
            label_password = new Label();
            textbox_password = new TextBox();
            label_login = new Label();
            textbox_login = new TextBox();
            logo = new Button();
            button_log_in = new Button();
            SuspendLayout();
            // 
            // devil_lable
            // 
            devil_lable.AutoSize = true;
            devil_lable.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            devil_lable.Location = new Point(130, 250);
            devil_lable.Name = "devil_lable";
            devil_lable.Size = new Size(60, 20);
            devil_lable.TabIndex = 19;
            devil_lable.Text = "label1";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_password.ForeColor = Color.Lime;
            label_password.Location = new Point(130, 193);
            label_password.Name = "label_password";
            label_password.Size = new Size(129, 27);
            label_password.TabIndex = 18;
            label_password.Text = "Password:";
            // 
            // textbox_password
            // 
            textbox_password.BackColor = SystemColors.InactiveCaptionText;
            textbox_password.BorderStyle = BorderStyle.None;
            textbox_password.Cursor = Cursors.IBeam;
            textbox_password.Font = new Font("Arial Rounded MT Bold", 12F);
            textbox_password.ForeColor = Color.Lime;
            textbox_password.Location = new Point(130, 223);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.Size = new Size(206, 24);
            textbox_password.TabIndex = 17;
            textbox_password.Text = "-";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_login.ForeColor = Color.Lime;
            label_login.Location = new Point(130, 129);
            label_login.Name = "label_login";
            label_login.Size = new Size(81, 27);
            label_login.TabIndex = 16;
            label_login.Text = "Login:";
            // 
            // textbox_login
            // 
            textbox_login.BackColor = SystemColors.InactiveCaptionText;
            textbox_login.BorderStyle = BorderStyle.None;
            textbox_login.Cursor = Cursors.IBeam;
            textbox_login.Font = new Font("Arial Rounded MT Bold", 12F);
            textbox_login.ForeColor = Color.Lime;
            textbox_login.Location = new Point(130, 159);
            textbox_login.Name = "textbox_login";
            textbox_login.Size = new Size(206, 24);
            textbox_login.TabIndex = 15;
            textbox_login.Text = "-";
            // 
            // logo
            // 
            logo.FlatStyle = FlatStyle.Popup;
            logo.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.Lime;
            logo.Image = Properties.Resources.banan_logo_img;
            logo.ImageAlign = ContentAlignment.MiddleLeft;
            logo.Location = new Point(5, 4);
            logo.Name = "logo";
            logo.Size = new Size(321, 103);
            logo.TabIndex = 14;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // button_log_in
            // 
            button_log_in.BackColor = Color.Lime;
            button_log_in.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button_log_in.FlatAppearance.BorderSize = 0;
            button_log_in.FlatStyle = FlatStyle.Flat;
            button_log_in.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_log_in.ForeColor = Color.Black;
            button_log_in.Location = new Point(130, 309);
            button_log_in.Name = "button_log_in";
            button_log_in.Size = new Size(206, 48);
            button_log_in.TabIndex = 13;
            button_log_in.Text = "Log in";
            button_log_in.UseVisualStyleBackColor = false;
            button_log_in.Click += button_log_in_Click;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(447, 420);
            Controls.Add(devil_lable);
            Controls.Add(label_password);
            Controls.Add(textbox_password);
            Controls.Add(label_login);
            Controls.Add(textbox_login);
            Controls.Add(logo);
            Controls.Add(button_log_in);
            Name = "Log_in";
            Text = "Log_in";
            Load += Log_in_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label devil_lable;
        private Label label_password;
        private TextBox textbox_password;
        private Label label_login;
        private TextBox textbox_login;
        private Button logo;
        private Button button_log_in;
    }
}