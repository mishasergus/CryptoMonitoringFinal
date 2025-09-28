namespace CryptoMonitoring
{
    partial class Crypto_farm
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
            panel_cards = new Panel();
            choose_cooling_sistem_button = new Button();
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
            // panel_cards
            // 
            panel_cards.AutoScroll = true;
            panel_cards.Location = new Point(12, 121);
            panel_cards.Name = "panel_cards";
            panel_cards.Size = new Size(651, 349);
            panel_cards.TabIndex = 5;
            // 
            // choose_cooling_sistem_button
            // 
            choose_cooling_sistem_button.BackColor = SystemColors.ActiveCaptionText;
            choose_cooling_sistem_button.BackgroundImage = Properties.Resources.plus_img;
            choose_cooling_sistem_button.BackgroundImageLayout = ImageLayout.Stretch;
            choose_cooling_sistem_button.FlatStyle = FlatStyle.Popup;
            choose_cooling_sistem_button.Location = new Point(704, 240);
            choose_cooling_sistem_button.Name = "choose_cooling_sistem_button";
            choose_cooling_sistem_button.Size = new Size(91, 84);
            choose_cooling_sistem_button.TabIndex = 12;
            choose_cooling_sistem_button.UseVisualStyleBackColor = false;
            // 
            // Crypto_farm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(833, 482);
            Controls.Add(choose_cooling_sistem_button);
            Controls.Add(panel_cards);
            Controls.Add(logo);
            Name = "Crypto_farm";
            Text = "Crypto_farm";
            Load += Crypto_farm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button logo;
        private Panel panel_cards;
        private Button choose_cooling_sistem_button;
    }
}