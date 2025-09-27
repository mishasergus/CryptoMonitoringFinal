namespace CryptoMonitoring
{
    partial class Add_crypto_form
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
            label_indificaton = new Label();
            textbox_indificaton = new TextBox();
            button_submit = new Button();
            SuspendLayout();
            // 
            // logo
            // 
            logo.FlatStyle = FlatStyle.Popup;
            logo.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.Lime;
            logo.Image = Properties.Resources.banan_logo_img;
            logo.ImageAlign = ContentAlignment.MiddleLeft;
            logo.Location = new Point(12, 21);
            logo.Name = "logo";
            logo.Size = new Size(318, 103);
            logo.TabIndex = 4;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // label_indificaton
            // 
            label_indificaton.AutoSize = true;
            label_indificaton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_indificaton.ForeColor = Color.Lime;
            label_indificaton.Location = new Point(55, 166);
            label_indificaton.Name = "label_indificaton";
            label_indificaton.Size = new Size(166, 27);
            label_indificaton.TabIndex = 18;
            label_indificaton.Text = "Name of coin:";
            // 
            // textbox_indificaton
            // 
            textbox_indificaton.BackColor = SystemColors.InactiveCaptionText;
            textbox_indificaton.BorderStyle = BorderStyle.None;
            textbox_indificaton.Cursor = Cursors.IBeam;
            textbox_indificaton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_indificaton.ForeColor = Color.Lime;
            textbox_indificaton.Location = new Point(55, 196);
            textbox_indificaton.Name = "textbox_indificaton";
            textbox_indificaton.Size = new Size(206, 24);
            textbox_indificaton.TabIndex = 17;
            textbox_indificaton.Text = "-";
            // 
            // button_submit
            // 
            button_submit.BackColor = Color.Lime;
            button_submit.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button_submit.FlatAppearance.BorderSize = 0;
            button_submit.FlatStyle = FlatStyle.Flat;
            button_submit.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_submit.ForeColor = Color.Black;
            button_submit.Location = new Point(81, 294);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(166, 47);
            button_submit.TabIndex = 19;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = false;
            button_submit.Click += button_submit_Click;
            // 
            // Add_crypto_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(342, 450);
            Controls.Add(button_submit);
            Controls.Add(label_indificaton);
            Controls.Add(textbox_indificaton);
            Controls.Add(logo);
            ForeColor = SystemColors.ControlText;
            Name = "Add_crypto_form";
            Text = "Add_crypto_form";
            Load += Add_crypto_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logo;
        private Label label_indificaton;
        private TextBox textbox_indificaton;
        private Button button_submit;
    }
}