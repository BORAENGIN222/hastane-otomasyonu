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
    public partial class doktorkayit : Form
    {
        public doktorkayit()
        {
            InitializeComponent();
            bolumleri_getir();
            doktorlari_getir();
        }

        void bolumleri_getir()
        {
            comboBoxBolumler.Items.Clear();
            var dataset = Db.bolumleri_getir();
            var kayitli_bolumler = dataset.Tables[0].Rows;
            foreach (DataRow bolum in kayitli_bolumler)
            {
                int bolum_id = Convert.ToInt32(bolum[0]);
                string bolum_adi = bolum[1].ToString();
                comboBoxBolumler.Items.Add(new ComboboxItem(bolum_adi, bolum_id));
                if (comboBoxBolumler.Items.Count > 0)
                {
                    comboBoxBolumler.SelectedIndex = 0;
                }
            }
        }

        void doktorlari_getir()
        {
            dataGridViewDoktorlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDoktorlar.MultiSelect = false;
            dataGridViewDoktorlar.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            dataGridViewDoktorlar.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            var dataset = Db.doktorlari_getir();
            dataGridViewDoktorlar.DataSource = dataset.Tables[0];
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            var doktor_adi = textBoxDoktorAdi.Text;
            var doktor_sifre = textBoxSifre.Text;
            ComboboxItem secili_bolum_item = comboBoxBolumler.SelectedItem as ComboboxItem;
            var bolum_id = secili_bolum_item.Value;
            Db.doktor_ekle(bolum_id, doktor_adi, doktor_sifre);
            textBoxDoktorAdi.Text = "";
            textBoxSifre.Text = "";
            doktorlari_getir();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            var secilidoktor = dataGridViewDoktorlar.SelectedRows[0];
            if (secilidoktor == null)
            {
                MessageBox.Show("Silmek için bölüm seçmelisiniz.");
                return;
            }
            var doktor_id = Convert.ToInt32(secilidoktor.Cells[0].Value);
            Db.doktor_sil(doktor_id);
            doktorlari_getir();
        }
    }
}
