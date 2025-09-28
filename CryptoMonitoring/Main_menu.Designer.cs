namespace CryptoMonitoring
{
    partial class Main_menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            logo = new Button();
            balance = new Label();
            add_crypto_button = new Button();
            crypto_list_panel = new Panel();
            pictureBox1 = new PictureBox();
            Profile_button = new Button();
            chat_button = new Button();
            leader_table_button = new Button();
            crypto_farm_button = new Button();
            achivment_button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            shop_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            logo.TabIndex = 3;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balance.ForeColor = Color.Lime;
            balance.Location = new Point(968, 54);
            balance.Name = "balance";
            balance.Size = new Size(30, 32);
            balance.TabIndex = 4;
            balance.Text = "0";
            // 
            // add_crypto_button
            // 
            add_crypto_button.BackColor = SystemColors.ControlDarkDark;
            add_crypto_button.FlatStyle = FlatStyle.Popup;
            add_crypto_button.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_crypto_button.ForeColor = Color.Lime;
            add_crypto_button.Location = new Point(12, 150);
            add_crypto_button.Name = "add_crypto_button";
            add_crypto_button.Size = new Size(1023, 43);
            add_crypto_button.TabIndex = 5;
            add_crypto_button.Text = "+";
            add_crypto_button.UseVisualStyleBackColor = false;
            add_crypto_button.Click += add_crypto_button_Click;
            // 
            // crypto_list_panel
            // 
            crypto_list_panel.AutoScroll = true;
            crypto_list_panel.Location = new Point(12, 199);
            crypto_list_panel.Name = "crypto_list_panel";
            crypto_list_panel.Size = new Size(1023, 284);
            crypto_list_panel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.purse_img1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(892, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 80);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Profile_button
            // 
            Profile_button.BackColor = SystemColors.ActiveCaptionText;
            Profile_button.BackgroundImage = Properties.Resources.profile_img;
            Profile_button.BackgroundImageLayout = ImageLayout.Stretch;
            Profile_button.FlatStyle = FlatStyle.Popup;
            Profile_button.Location = new Point(311, 27);
            Profile_button.Name = "Profile_button";
            Profile_button.Size = new Size(91, 84);
            Profile_button.TabIndex = 8;
            Profile_button.UseVisualStyleBackColor = false;
            Profile_button.Click += Profile_button_Click;
            // 
            // chat_button
            // 
            chat_button.BackColor = SystemColors.ActiveCaptionText;
            chat_button.BackgroundImage = (Image)resources.GetObject("chat_button.BackgroundImage");
            chat_button.BackgroundImageLayout = ImageLayout.Stretch;
            chat_button.FlatStyle = FlatStyle.Popup;
            chat_button.Location = new Point(408, 27);
            chat_button.Name = "chat_button";
            chat_button.Size = new Size(91, 84);
            chat_button.TabIndex = 9;
            chat_button.UseVisualStyleBackColor = false;
            chat_button.Click += chat_button_Click;
            // 
            // leader_table_button
            // 
            leader_table_button.BackColor = SystemColors.ActiveCaptionText;
            leader_table_button.BackgroundImage = (Image)resources.GetObject("leader_table_button.BackgroundImage");
            leader_table_button.BackgroundImageLayout = ImageLayout.Stretch;
            leader_table_button.FlatStyle = FlatStyle.Popup;
            leader_table_button.Location = new Point(505, 27);
            leader_table_button.Name = "leader_table_button";
            leader_table_button.Size = new Size(91, 84);
            leader_table_button.TabIndex = 10;
            leader_table_button.UseVisualStyleBackColor = false;
            leader_table_button.Click += leader_table_button_Click;
            // 
            // crypto_farm_button
            // 
            crypto_farm_button.BackColor = SystemColors.ActiveCaptionText;
            crypto_farm_button.BackgroundImage = Properties.Resources.video_card_green_img;
            crypto_farm_button.BackgroundImageLayout = ImageLayout.Stretch;
            crypto_farm_button.FlatStyle = FlatStyle.Popup;
            crypto_farm_button.Location = new Point(602, 27);
            crypto_farm_button.Name = "crypto_farm_button";
            crypto_farm_button.Size = new Size(91, 84);
            crypto_farm_button.TabIndex = 11;
            crypto_farm_button.UseVisualStyleBackColor = false;
            crypto_farm_button.Click += crypto_farm_button_Click;
            // 
            // achivment_button
            // 
            achivment_button.BackColor = SystemColors.ActiveCaptionText;
            achivment_button.BackgroundImage = Properties.Resources.icons8_achivement_100;
            achivment_button.BackgroundImageLayout = ImageLayout.Stretch;
            achivment_button.FlatStyle = FlatStyle.Popup;
            achivment_button.Location = new Point(699, 27);
            achivment_button.Name = "achivment_button";
            achivment_button.Size = new Size(91, 84);
            achivment_button.TabIndex = 10;
            achivment_button.UseVisualStyleBackColor = false;
            achivment_button.Click += achivment_button_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // shop_button
            // 
            shop_button.BackColor = SystemColors.ActiveCaptionText;
            shop_button.BackgroundImage = Properties.Resources.shop_img;
            shop_button.BackgroundImageLayout = ImageLayout.Stretch;
            shop_button.FlatStyle = FlatStyle.Popup;
            shop_button.Location = new Point(795, 31);
            shop_button.Name = "shop_button";
            shop_button.Size = new Size(91, 84);
            shop_button.TabIndex = 12;
            shop_button.UseVisualStyleBackColor = false;
            shop_button.Click += shop_button_Click;
            // 
            // Main_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1048, 495);
            Controls.Add(shop_button);
            Controls.Add(achivment_button);
            Controls.Add(crypto_farm_button);
            Controls.Add(leader_table_button);
            Controls.Add(chat_button);
            Controls.Add(Profile_button);
            Controls.Add(pictureBox1);
            Controls.Add(crypto_list_panel);
            Controls.Add(add_crypto_button);
            Controls.Add(balance);
            Controls.Add(logo);
            Name = "Main_menu";
            Text = "Main_menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logo;
        private Label balance;
        private Button add_crypto_button;
        private Panel crypto_list_panel;
        private PictureBox pictureBox1;
        private Button Profile_button;
        private Button chat_button;
        private Button leader_table_button;
        private Button crypto_farm_button;
        private Button achivment_button;
        private System.Windows.Forms.Timer timer1;
        private Button shop_button;
    }
}