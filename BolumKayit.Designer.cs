namespace HastaneOtomasyon
{
    partial class BolumKayit
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
            textBoxBolumAdi = new TextBox();
            buttonEkle = new Button();
            dataGridViewBolumler = new DataGridView();
            buttonSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBolumler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Bölüm Adı : ";
            // 
            // textBoxBolumAdi
            // 
            textBoxBolumAdi.Location = new Point(104, 20);
            textBoxBolumAdi.Name = "textBoxBolumAdi";
            textBoxBolumAdi.Size = new Size(212, 23);
            textBoxBolumAdi.TabIndex = 1;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(210, 61);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(106, 32);
            buttonEkle.TabIndex = 2;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // dataGridViewBolumler
            // 
            dataGridViewBolumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBolumler.Location = new Point(12, 109);
            dataGridViewBolumler.Name = "dataGridViewBolumler";
            dataGridViewBolumler.RowTemplate.Height = 25;
            dataGridViewBolumler.Size = new Size(304, 240);
            dataGridViewBolumler.TabIndex = 3;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(88, 61);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(106, 32);
            buttonSil.TabIndex = 4;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // BolumKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(328, 361);
            Controls.Add(buttonSil);
            Controls.Add(dataGridViewBolumler);
            Controls.Add(buttonEkle);
            Controls.Add(textBoxBolumAdi);
            Controls.Add(label1);
            Name = "BolumKayit";
            Text = "BolumKayit";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBolumler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxBolumAdi;
        private Button buttonEkle;
        private DataGridView dataGridViewBolumler;
        private Button buttonSil;
    }
}