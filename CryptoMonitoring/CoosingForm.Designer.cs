namespace CryptoMonitoring
{
    partial class CoosingForm
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
            panel_items = new Panel();
            SuspendLayout();
            // 
            // panel_items
            // 
            panel_items.AutoScroll = true;
            panel_items.Location = new Point(12, 12);
            panel_items.Name = "panel_items";
            panel_items.Size = new Size(312, 426);
            panel_items.TabIndex = 0;
            // 
            // CoosingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(336, 450);
            Controls.Add(panel_items);
            Name = "CoosingForm";
            Text = "CoosingForm";
            Load += CoosingForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_items;
    }
}