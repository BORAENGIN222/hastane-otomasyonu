namespace HastaneOtomasyon
{
    partial class doktorkayit
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
            label2 = new Label();
            label3 = new Label();
            comboBoxBolumler = new ComboBox();
            textBoxSifre = new TextBox();
            buttonKayit = new Button();
            dataGridViewDoktorlar = new DataGridView();
            textBoxDoktorAdi = new TextBox();
            buttonSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoktorlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Bölüm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 104);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // comboBoxBolumler
            // 
            comboBoxBolumler.Location = new Point(114, 22);
            comboBoxBolumler.Name = "comboBoxBolumler";
            comboBoxBolumler.Size = new Size(356, 23);
            comboBoxBolumler.TabIndex = 6;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(114, 104);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(356, 23);
            textBoxSifre.TabIndex = 8;
            // 
            // buttonKayit
            // 
            buttonKayit.Location = new Point(353, 149);
            buttonKayit.Name = "buttonKayit";
            buttonKayit.Size = new Size(117, 34);
            buttonKayit.TabIndex = 9;
            buttonKayit.Text = "KAYIT";
            buttonKayit.UseVisualStyleBackColor = true;
            buttonKayit.Click += buttonKayit_Click;
            // 
            // dataGridViewDoktorlar
            // 
            dataGridViewDoktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoktorlar.Location = new Point(31, 199);
            dataGridViewDoktorlar.Name = "dataGridViewDoktorlar";
            dataGridViewDoktorlar.RowTemplate.Height = 25;
            dataGridViewDoktorlar.Size = new Size(439, 150);
            dataGridViewDoktorlar.TabIndex = 10;
            // 
            // textBoxDoktorAdi
            // 
            textBoxDoktorAdi.Location = new Point(114, 64);
            textBoxDoktorAdi.Name = "textBoxDoktorAdi";
            textBoxDoktorAdi.Size = new Size(356, 23);
            textBoxDoktorAdi.TabIndex = 11;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(235, 149);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(106, 33);
            buttonSil.TabIndex = 12;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // doktorkayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(483, 361);
            Controls.Add(buttonSil);
            Controls.Add(textBoxDoktorAdi);
            Controls.Add(dataGridViewDoktorlar);
            Controls.Add(buttonKayit);
            Controls.Add(textBoxSifre);
            Controls.Add(comboBoxBolumler);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "doktorkayit";
            Text = "doktorkayit";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoktorlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxBolumler;
        private TextBox textBoxSifre;
        private Button buttonKayit;
        private DataGridView dataGridViewDoktorlar;
        private TextBox textBoxDoktorAdi;
        private Button buttonSil;
    }
}