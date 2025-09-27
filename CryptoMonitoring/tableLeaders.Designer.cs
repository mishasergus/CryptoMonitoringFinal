namespace CryptoMonitoring
{
    partial class tableLeaders
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
            dataGridViewLeaders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLeaders
            // 
            dataGridViewLeaders.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewLeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeaders.Dock = DockStyle.Fill;
            dataGridViewLeaders.Location = new Point(0, 0);
            dataGridViewLeaders.Name = "dataGridViewLeaders";
            dataGridViewLeaders.RowHeadersWidth = 51;
            dataGridViewLeaders.Size = new Size(800, 450);
            dataGridViewLeaders.TabIndex = 0;
            dataGridViewLeaders.CellContentClick += dataGridViewLeaders_CellContentClick;
            // 
            // tableLeaders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewLeaders);
            Name = "tableLeaders";
            Text = "tableLeaders";
            Load += tableLeaders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLeaders;
    }
}