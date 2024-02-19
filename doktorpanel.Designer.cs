namespace HastaneOtomasyon
{
    partial class doktorpanel
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
            comboBoxDoktor = new ComboBox();
            label1 = new Label();
            dataGridViewRandevular = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).BeginInit();
            SuspendLayout();
            // 
            // comboBoxDoktor
            // 
            comboBoxDoktor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoktor.FormattingEnabled = true;
            comboBoxDoktor.Location = new Point(88, 12);
            comboBoxDoktor.Name = "comboBoxDoktor";
            comboBoxDoktor.Size = new Size(256, 23);
            comboBoxDoktor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Doktor Adı :";
            // 
            // dataGridViewRandevular
            // 
            dataGridViewRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRandevular.Location = new Point(12, 70);
            dataGridViewRandevular.Name = "dataGridViewRandevular";
            dataGridViewRandevular.RowTemplate.Height = 25;
            dataGridViewRandevular.Size = new Size(776, 368);
            dataGridViewRandevular.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Randevular :";
            // 
            // button1
            // 
            button1.Location = new Point(510, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "GETİR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "randevu", "randevu bekliyor", "muaine oldu" });
            comboBox1.Location = new Point(369, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // doktorpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridViewRandevular);
            Controls.Add(label1);
            Controls.Add(comboBoxDoktor);
            Name = "doktorpanel";
            Text = "doktorpanel";
            Load += doktorpanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDoktor;
        private Label label1;
        private DataGridView dataGridViewRandevular;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
    }
}