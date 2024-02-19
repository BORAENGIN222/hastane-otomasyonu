using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class doktorgiris : Form
    {
        public doktorgiris()
        {
            InitializeComponent();
            doktorlari_getir();
        }

        void doktorlari_getir()
        {
            comboBoxDoktor.SelectedItem = null;
            comboBoxDoktor.Text = "";
            comboBoxDoktor.Items.Clear();
            var dataset = Db.doktorlari_getir();
            var kayitli_doktorlar = dataset.Tables[0].Rows;
            foreach (DataRow doktor in kayitli_doktorlar)
            {
                int doktor_id = Convert.ToInt32(doktor[0]);
                string doktor_adi = doktor[1].ToString();
                comboBoxDoktor.Items.Add(new ComboboxItem(doktor_adi, doktor_id));
                if (comboBoxDoktor.Items.Count > 0)
                {
                    comboBoxDoktor.SelectedIndex = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sifre = textBoxSifre.Text;
            if (String.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Şifre boş olmamalı.");
                return;
            }

            ComboboxItem secili_doktor_item = comboBoxDoktor.SelectedItem as ComboboxItem;
            if (secili_doktor_item == null)
            {
                MessageBox.Show("Doktor seçmelisin.");
                return;
            }
            var doktor_id = secili_doktor_item.Value;

            bool doktor_kontrol = Db.doktor_kontrol(doktor_id, sifre);
            if (doktor_kontrol)
            {
                doktorpanel doktorpanel = new doktorpanel();
                doktorpanel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yanlış şifre girdiniz.");
            }
        }
    }
}
