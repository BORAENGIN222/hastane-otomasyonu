namespace HastaneOtomasyon
{
    partial class doktorgiris
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
            label1 = new Label();
            comboBoxDoktor = new ComboBox();
            label2 = new Label();
            textBoxSifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Doktor Adı :";
            // 
            // comboBoxDoktor
            // 
            comboBoxDoktor.FormattingEnabled = true;
            comboBoxDoktor.Location = new Point(92, 21);
            comboBoxDoktor.Name = "comboBoxDoktor";
            comboBoxDoktor.Size = new Size(256, 23);
            comboBoxDoktor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(92, 69);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(256, 23);
            textBoxSifre.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(234, 108);
            button1.Name = "button1";
            button1.Size = new Size(114, 46);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // doktorgiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(371, 185);
            Controls.Add(button1);
            Controls.Add(textBoxSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDoktor);
            Name = "doktorgiris";
            Text = "doktorgiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxDoktor;
        private Label label2;
        private TextBox textBoxSifre;
        private Button button1;
    }
}