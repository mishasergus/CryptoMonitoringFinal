namespace CryptoMonitoring
{
    partial class Crypto_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crypto_menu));
            button_graphic = new Button();
            logo = new Button();
            textbox_USDT1 = new TextBox();
            label_USDT1 = new Label();
            USDT_to_crypto_button1 = new Button();
            label_crypto1 = new Label();
            textbox_crypto1 = new TextBox();
            label_USDT2 = new Label();
            textbox_USDT2 = new TextBox();
            crypto_to_USRT_button2 = new Button();
            label_crypto2 = new Label();
            textbox_crypto2 = new TextBox();
            curse_label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label_balance = new Label();
            SuspendLayout();
            // 
            // button_graphic
            // 
            button_graphic.BackColor = Color.Lime;
            button_graphic.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button_graphic.FlatAppearance.BorderSize = 0;
            button_graphic.FlatStyle = FlatStyle.Flat;
            button_graphic.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_graphic.ForeColor = Color.Black;
            button_graphic.Location = new Point(603, 47);
            button_graphic.Name = "button_graphic";
            button_graphic.Size = new Size(166, 47);
            button_graphic.TabIndex = 21;
            button_graphic.Text = "Graphic";
            button_graphic.UseVisualStyleBackColor = false;
            button_graphic.Click += button_graphic_Click;
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
            logo.TabIndex = 20;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // textbox_USDT1
            // 
            textbox_USDT1.BackColor = SystemColors.InactiveCaptionText;
            textbox_USDT1.BorderStyle = BorderStyle.None;
            textbox_USDT1.Cursor = Cursors.IBeam;
            textbox_USDT1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_USDT1.ForeColor = Color.Lime;
            textbox_USDT1.Location = new Point(149, 221);
            textbox_USDT1.Name = "textbox_USDT1";
            textbox_USDT1.Size = new Size(199, 39);
            textbox_USDT1.TabIndex = 22;
            textbox_USDT1.Text = "-";
            textbox_USDT1.TextChanged += textbox_USDT1_TextChanged;
            // 
            // label_USDT1
            // 
            label_USDT1.AutoSize = true;
            label_USDT1.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            label_USDT1.ForeColor = Color.Lime;
            label_USDT1.Location = new Point(20, 221);
            label_USDT1.Name = "label_USDT1";
            label_USDT1.Size = new Size(123, 39);
            label_USDT1.TabIndex = 23;
            label_USDT1.Text = "USDT:";
            // 
            // USDT_to_crypto_button1
            // 
            USDT_to_crypto_button1.BackColor = SystemColors.ActiveCaptionText;
            USDT_to_crypto_button1.BackgroundImage = (Image)resources.GetObject("USDT_to_crypto_button1.BackgroundImage");
            USDT_to_crypto_button1.BackgroundImageLayout = ImageLayout.Stretch;
            USDT_to_crypto_button1.FlatStyle = FlatStyle.Popup;
            USDT_to_crypto_button1.Location = new Point(354, 203);
            USDT_to_crypto_button1.Name = "USDT_to_crypto_button1";
            USDT_to_crypto_button1.Size = new Size(79, 73);
            USDT_to_crypto_button1.TabIndex = 24;
            USDT_to_crypto_button1.UseVisualStyleBackColor = false;
            USDT_to_crypto_button1.Click += USDT_to_crypto_button1_Click;
            // 
            // label_crypto1
            // 
            label_crypto1.AutoSize = true;
            label_crypto1.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            label_crypto1.ForeColor = Color.Lime;
            label_crypto1.Location = new Point(439, 221);
            label_crypto1.Name = "label_crypto1";
            label_crypto1.Size = new Size(169, 39);
            label_crypto1.TabIndex = 26;
            label_crypto1.Text = "CRYPTO:";
            // 
            // textbox_crypto1
            // 
            textbox_crypto1.BackColor = SystemColors.InactiveCaptionText;
            textbox_crypto1.BorderStyle = BorderStyle.None;
            textbox_crypto1.Cursor = Cursors.IBeam;
            textbox_crypto1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_crypto1.ForeColor = Color.Lime;
            textbox_crypto1.Location = new Point(568, 221);
            textbox_crypto1.Name = "textbox_crypto1";
            textbox_crypto1.Size = new Size(220, 39);
            textbox_crypto1.TabIndex = 25;
            textbox_crypto1.Text = "-";
            // 
            // label_USDT2
            // 
            label_USDT2.AutoSize = true;
            label_USDT2.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            label_USDT2.ForeColor = Color.Lime;
            label_USDT2.Location = new Point(439, 334);
            label_USDT2.Name = "label_USDT2";
            label_USDT2.Size = new Size(123, 39);
            label_USDT2.TabIndex = 31;
            label_USDT2.Text = "USDT:";
            // 
            // textbox_USDT2
            // 
            textbox_USDT2.BackColor = SystemColors.InactiveCaptionText;
            textbox_USDT2.BorderStyle = BorderStyle.None;
            textbox_USDT2.Cursor = Cursors.IBeam;
            textbox_USDT2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_USDT2.ForeColor = Color.Lime;
            textbox_USDT2.Location = new Point(568, 334);
            textbox_USDT2.Name = "textbox_USDT2";
            textbox_USDT2.Size = new Size(220, 39);
            textbox_USDT2.TabIndex = 30;
            textbox_USDT2.Text = "-";
            // 
            // crypto_to_USRT_button2
            // 
            crypto_to_USRT_button2.BackColor = SystemColors.ActiveCaptionText;
            crypto_to_USRT_button2.BackgroundImage = (Image)resources.GetObject("crypto_to_USRT_button2.BackgroundImage");
            crypto_to_USRT_button2.BackgroundImageLayout = ImageLayout.Stretch;
            crypto_to_USRT_button2.FlatStyle = FlatStyle.Popup;
            crypto_to_USRT_button2.Location = new Point(354, 316);
            crypto_to_USRT_button2.Name = "crypto_to_USRT_button2";
            crypto_to_USRT_button2.Size = new Size(79, 73);
            crypto_to_USRT_button2.TabIndex = 29;
            crypto_to_USRT_button2.UseVisualStyleBackColor = false;
            crypto_to_USRT_button2.Click += crypto_to_USRT_button2_Click;
            // 
            // label_crypto2
            // 
            label_crypto2.AutoSize = true;
            label_crypto2.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            label_crypto2.ForeColor = Color.Lime;
            label_crypto2.Location = new Point(20, 334);
            label_crypto2.Name = "label_crypto2";
            label_crypto2.Size = new Size(169, 39);
            label_crypto2.TabIndex = 28;
            label_crypto2.Text = "CRYPTO:";
            // 
            // textbox_crypto2
            // 
            textbox_crypto2.BackColor = SystemColors.InactiveCaptionText;
            textbox_crypto2.BorderStyle = BorderStyle.None;
            textbox_crypto2.Cursor = Cursors.IBeam;
            textbox_crypto2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_crypto2.ForeColor = Color.Lime;
            textbox_crypto2.Location = new Point(149, 334);
            textbox_crypto2.Name = "textbox_crypto2";
            textbox_crypto2.Size = new Size(199, 39);
            textbox_crypto2.TabIndex = 27;
            textbox_crypto2.Text = "-";
            textbox_crypto2.TextChanged += textbox_crypto2_TextChanged;
            // 
            // curse_label
            // 
            curse_label.AutoSize = true;
            curse_label.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            curse_label.ForeColor = Color.Lime;
            curse_label.Location = new Point(20, 141);
            curse_label.Name = "curse_label";
            curse_label.Size = new Size(28, 39);
            curse_label.TabIndex = 32;
            curse_label.Text = "-";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // label_balance
            // 
            label_balance.AutoSize = true;
            label_balance.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_balance.ForeColor = Color.Lime;
            label_balance.Location = new Point(320, 47);
            label_balance.Name = "label_balance";
            label_balance.Size = new Size(20, 27);
            label_balance.TabIndex = 33;
            label_balance.Text = "-";
            // 
            // Crypto_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label_balance);
            Controls.Add(curse_label);
            Controls.Add(label_USDT2);
            Controls.Add(textbox_USDT2);
            Controls.Add(crypto_to_USRT_button2);
            Controls.Add(label_crypto2);
            Controls.Add(textbox_crypto2);
            Controls.Add(label_crypto1);
            Controls.Add(textbox_crypto1);
            Controls.Add(USDT_to_crypto_button1);
            Controls.Add(label_USDT1);
            Controls.Add(textbox_USDT1);
            Controls.Add(button_graphic);
            Controls.Add(logo);
            Name = "Crypto_menu";
            Text = "Crypto_menu";
            Load += Crypto_menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_graphic;
        private Button logo;
        private TextBox textbox_USDT1;
        private Label label_USDT1;
        private Button USDT_to_crypto_button1;
        private Label label_crypto1;
        private TextBox textbox_crypto1;
        private Label label_USDT2;
        private TextBox textbox_USDT2;
        private Button crypto_to_USRT_button2;
        private Label label_crypto2;
        private TextBox textbox_crypto2;
        private Label curse_label;
        private System.Windows.Forms.Timer timer1;
        private Label label_balance;
    }
}