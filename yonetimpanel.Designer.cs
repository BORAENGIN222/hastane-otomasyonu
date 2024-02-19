namespace HastaneOtomasyon
{
    partial class yonetimpanel
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
            buttonDoktorKayit = new Button();
            buttonBolumKaydi = new Button();
            SuspendLayout();
            // 
            // buttonDoktorKayit
            // 
            buttonDoktorKayit.Location = new Point(204, 12);
            buttonDoktorKayit.Name = "buttonDoktorKayit";
            buttonDoktorKayit.Size = new Size(200, 120);
            buttonDoktorKayit.TabIndex = 3;
            buttonDoktorKayit.Text = "Doktor Kaydı";
            buttonDoktorKayit.UseVisualStyleBackColor = true;
            buttonDoktorKayit.Click += buttonDoktorKayit_Click;
            // 
            // buttonBolumKaydi
            // 
            buttonBolumKaydi.Location = new Point(12, 12);
            buttonBolumKaydi.Name = "buttonBolumKaydi";
            buttonBolumKaydi.Size = new Size(186, 120);
            buttonBolumKaydi.TabIndex = 2;
            buttonBolumKaydi.Text = "Bölüm Kaydı";
            buttonBolumKaydi.UseVisualStyleBackColor = true;
            buttonBolumKaydi.Click += buttonBolumKaydi_Click;
            // 
            // yonetimpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(413, 146);
            Controls.Add(buttonDoktorKayit);
            Controls.Add(buttonBolumKaydi);
            Name = "yonetimpanel";
            Text = "yonetimpanel";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDoktorKayit;
        private Button buttonBolumKaydi;
    }
}