namespace CryptoMonitoring
{
    partial class Chat_form
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
            textbox_massege = new TextBox();
            seng_button = new Button();
            chat_pannel = new Panel();
            SuspendLayout();
            // 
            // textbox_massege
            // 
            textbox_massege.BackColor = SystemColors.InactiveCaptionText;
            textbox_massege.BorderStyle = BorderStyle.None;
            textbox_massege.Cursor = Cursors.IBeam;
            textbox_massege.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_massege.ForeColor = Color.Lime;
            textbox_massege.Location = new Point(12, 414);
            textbox_massege.Name = "textbox_massege";
            textbox_massege.Size = new Size(309, 27);
            textbox_massege.TabIndex = 18;
            textbox_massege.Text = "-";
            // 
            // seng_button
            // 
            seng_button.BackColor = SystemColors.ActiveCaptionText;
            seng_button.BackgroundImage = Properties.Resources.send_img;
            seng_button.BackgroundImageLayout = ImageLayout.Stretch;
            seng_button.FlatStyle = FlatStyle.Popup;
            seng_button.Location = new Point(327, 405);
            seng_button.Name = "seng_button";
            seng_button.Size = new Size(46, 44);
            seng_button.TabIndex = 19;
            seng_button.UseVisualStyleBackColor = false;
            seng_button.Click += seng_button_Click;
            // 
            // chat_pannel
            // 
            chat_pannel.AutoScroll = true;
            chat_pannel.Location = new Point(12, 12);
            chat_pannel.Name = "chat_pannel";
            chat_pannel.Size = new Size(351, 387);
            chat_pannel.TabIndex = 20;
            // 
            // Chat_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(375, 450);
            Controls.Add(chat_pannel);
            Controls.Add(seng_button);
            Controls.Add(textbox_massege);
            Name = "Chat_form";
            Text = "Chat_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_massege;
        private Button seng_button;
        private Panel chat_pannel;
    }
}