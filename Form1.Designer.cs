namespace HastaneOtomasyon
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
            buttonYonetimPanel = new Button();
            buttonDoktorPanel = new Button();
            buttonHastaPanel = new Button();
            SuspendLayout();
            // 
            // buttonYonetimPanel
            // 
            buttonYonetimPanel.Location = new Point(49, 29);
            buttonYonetimPanel.Name = "buttonYonetimPanel";
            buttonYonetimPanel.Size = new Size(281, 54);
            buttonYonetimPanel.TabIndex = 0;
            buttonYonetimPanel.Text = "Yönetim Panel";
            buttonYonetimPanel.UseVisualStyleBackColor = true;
            buttonYonetimPanel.Click += buttonYonetimPanel_Click;
            // 
            // buttonDoktorPanel
            // 
            buttonDoktorPanel.Location = new Point(49, 107);
            buttonDoktorPanel.Name = "buttonDoktorPanel";
            buttonDoktorPanel.Size = new Size(281, 54);
            buttonDoktorPanel.TabIndex = 2;
            buttonDoktorPanel.Text = "Doktor Panel";
            buttonDoktorPanel.UseVisualStyleBackColor = true;
            buttonDoktorPanel.Click += buttonDoktorPanel_Click;
            // 
            // buttonHastaPanel
            // 
            buttonHastaPanel.Location = new Point(49, 181);
            buttonHastaPanel.Name = "buttonHastaPanel";
            buttonHastaPanel.Size = new Size(281, 54);
            buttonHastaPanel.TabIndex = 3;
            buttonHastaPanel.Text = "Hasta Paneli";
            buttonHastaPanel.UseVisualStyleBackColor = true;
            buttonHastaPanel.Click += buttonHastaPanel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(374, 382);
            Controls.Add(buttonHastaPanel);
            Controls.Add(buttonDoktorPanel);
            Controls.Add(buttonYonetimPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonYonetimPanel;
        private Button buttonDoktorPanel;
        private Button buttonHastaPanel;
    }
}
//hastalar için yeni bir tablo ve doktorgiriste doktoradı olan yeri combobox yerine textbox yap.//