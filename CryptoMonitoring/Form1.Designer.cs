namespace CryptoMonitoring
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sing_up = new Button();
            logo = new Button();
            log_in = new Button();
            or = new Label();
            SuspendLayout();
            // 
            // sing_up
            // 
            sing_up.BackColor = Color.Lime;
            sing_up.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            sing_up.FlatAppearance.BorderSize = 0;
            sing_up.FlatStyle = FlatStyle.Flat;
            sing_up.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sing_up.ForeColor = Color.Black;
            sing_up.Location = new Point(145, 168);
            sing_up.Name = "sing_up";
            sing_up.Size = new Size(206, 48);
            sing_up.TabIndex = 0;
            sing_up.Text = "Sing up";
            sing_up.UseVisualStyleBackColor = false;
            sing_up.Click += sing_up_Click;
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
            logo.Size = new Size(319, 103);
            logo.TabIndex = 2;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // log_in
            // 
            log_in.BackColor = Color.Black;
            log_in.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            log_in.FlatAppearance.BorderSize = 0;
            log_in.FlatStyle = FlatStyle.Popup;
            log_in.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_in.ForeColor = Color.Lime;
            log_in.Location = new Point(145, 267);
            log_in.Name = "log_in";
            log_in.Size = new Size(206, 48);
            log_in.TabIndex = 3;
            log_in.Text = "Log in";
            log_in.UseVisualStyleBackColor = false;
            log_in.Click += log_in_Click;
            // 
            // or
            // 
            or.AutoSize = true;
            or.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            or.ForeColor = Color.Lime;
            or.Location = new Point(162, 241);
            or.Name = "or";
            or.Size = new Size(171, 23);
            or.TabIndex = 4;
            or.Text = "----------or----------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(516, 455);
            Controls.Add(or);
            Controls.Add(log_in);
            Controls.Add(logo);
            Controls.Add(sing_up);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sing_up;
        private Button logo;
        private Button log_in;
        private Label or;
    }
}
