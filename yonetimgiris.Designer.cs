namespace HastaneOtomasyon
{
    partial class yonetimgiris
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
            textBoxSifre = new TextBox();
            label1 = new Label();
            buttonGiris = new Button();
            SuspendLayout();
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(56, 12);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.PasswordChar = '*';
            textBoxSifre.Size = new Size(189, 23);
            textBoxSifre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Şifre :";
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(108, 41);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(137, 34);
            buttonGiris.TabIndex = 2;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // yonetimgiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(257, 85);
            Controls.Add(buttonGiris);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Name = "yonetimgiris";
            Text = "yonetimgiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSifre;
        private Label label1;
        private Button buttonGiris;
    }
}