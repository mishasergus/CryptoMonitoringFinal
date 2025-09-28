namespace CryptoMonitoring
{
    partial class Profile_spectator
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
            label_description = new Label();
            label_name = new Label();
            picture_avatar = new PictureBox();
            logo = new Button();
            label_balance = new Label();
            ((System.ComponentModel.ISupportInitialize)picture_avatar).BeginInit();
            SuspendLayout();
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_description.ForeColor = Color.Lime;
            label_description.Location = new Point(17, 327);
            label_description.Name = "label_description";
            label_description.Size = new Size(148, 27);
            label_description.TabIndex = 24;
            label_description.Text = "Description:";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_name.ForeColor = Color.Lime;
            label_name.Location = new Point(17, 273);
            label_name.Name = "label_name";
            label_name.Size = new Size(84, 27);
            label_name.TabIndex = 23;
            label_name.Text = "Name:";
            // 
            // picture_avatar
            // 
            picture_avatar.BackgroundImageLayout = ImageLayout.Stretch;
            picture_avatar.Location = new Point(17, 147);
            picture_avatar.Name = "picture_avatar";
            picture_avatar.Size = new Size(95, 84);
            picture_avatar.TabIndex = 22;
            picture_avatar.TabStop = false;
            // 
            // logo
            // 
            logo.FlatStyle = FlatStyle.Popup;
            logo.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.Lime;
            logo.Image = Properties.Resources.banan_logo_img;
            logo.ImageAlign = ContentAlignment.MiddleLeft;
            logo.Location = new Point(17, 21);
            logo.Name = "logo";
            logo.Size = new Size(314, 103);
            logo.TabIndex = 21;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // label_balance
            // 
            label_balance.AutoSize = true;
            label_balance.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label_balance.ForeColor = Color.Lime;
            label_balance.Location = new Point(17, 300);
            label_balance.Name = "label_balance";
            label_balance.Size = new Size(112, 27);
            label_balance.TabIndex = 25;
            label_balance.Text = "Balance:";
            // 
            // Profile_spectator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(343, 450);
            Controls.Add(label_balance);
            Controls.Add(label_description);
            Controls.Add(label_name);
            Controls.Add(picture_avatar);
            Controls.Add(logo);
            Name = "Profile_spectator";
            Text = "Profile_spectator";
            Load += Profile_spectator_Load;
            ((System.ComponentModel.ISupportInitialize)picture_avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_description;
        private Label label_name;
        private PictureBox picture_avatar;
        private Button logo;
        private Label label_balance;
    }
}