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
    public partial class hastakayit : Form
    {
        public hastakayit()
        {
            InitializeComponent();
            dateTimePickerRandevuTarih.Format = DateTimePickerFormat.Custom;
            dateTimePickerRandevuTarih.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            bolumleri_getir();
        }

        void bolumleri_getir()
        {
            comboBoxBolum.Items.Clear();
            var dataset = Db.bolumleri_getir();
            var kayitli_bolumler = dataset.Tables[0].Rows;
            foreach (DataRow bolum in kayitli_bolumler)
            {
                int bolum_id = Convert.ToInt32(bolum[0]);
                string bolum_adi = bolum[1].ToString();
                comboBoxBolum.Items.Add(new ComboboxItem(bolum_adi, bolum_id));
                if (comboBoxBolum.Items.Count > 0)
                {
                    comboBoxBolum.SelectedIndex = 0;
                }
            }
        }

        private void comboBoxBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem secili_bolum_item = comboBoxBolum.SelectedItem as ComboboxItem;
            doktorlari_getir(secili_bolum_item.Value);
        }

        void doktorlari_getir(int bolum_id)
        {
            comboBoxDoktor.SelectedItem = null;
            comboBoxDoktor.Text = "";
            comboBoxDoktor.Items.Clear();
            var dataset = Db.doktorlari_getir(bolum_id);
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

        private void buttonRandevuOlustur_Click(object sender, EventArgs e)
        {
            var hasta_tc = textBoxHastaTc.Text;
            var hasta_adi = textBoxHastaAdSoyad.Text;

            if (String.IsNullOrEmpty(hasta_tc) || String.IsNullOrEmpty(hasta_adi))
            {
                MessageBox.Show("Tüm bilgileri doldurmalısın.");
                return;
            }

            ComboboxItem secili_bolum_item = comboBoxBolum.SelectedItem as ComboboxItem;
            if (secili_bolum_item == null)
            {
                MessageBox.Show("Bölüm seçmelisin.");
                return;
            }
            var bolum_id = secili_bolum_item.Value;

            ComboboxItem secili_doktor_item = comboBoxDoktor.SelectedItem as ComboboxItem;
            if (secili_doktor_item == null)
            {
                MessageBox.Show("Doktor seçmelisin.");
                return;
            }
            var doktor_id = secili_doktor_item.Value;
            int status = 1;
            var randevu_tarih = dateTimePickerRandevuTarih.Value;
            Db.randevu_kayit(hasta_tc, hasta_adi, randevu_tarih, bolum_id, doktor_id, status);
            hasta_tc = "";
            hasta_adi = "";
            dateTimePickerRandevuTarih.Value = DateTime.Now;
            MessageBox.Show("Randevu başarıyla kaydedildi.");
        }
    }
}
