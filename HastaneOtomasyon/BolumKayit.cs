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
    public partial class BolumKayit : Form
    {
        public BolumKayit()
        {
            InitializeComponent();

            gridAyari();
            bolumleri_yukle();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            var bolum_adi = textBoxBolumAdi.Text;
            Db.yeni_bolum_ekle(bolum_adi);
            textBoxBolumAdi.Text = "";
            bolumleri_yukle();
        }

        void gridAyari()
        {
            dataGridViewBolumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBolumler.MultiSelect = false;
            dataGridViewBolumler.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            dataGridViewBolumler.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
        }

        void bolumleri_yukle()
        {
            DataSet dataset = Db.bolumleri_getir();
            dataGridViewBolumler.DataSource = dataset.Tables[0];
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            var seciliBolum = dataGridViewBolumler.SelectedRows[0];
            if (seciliBolum == null)
            {
                MessageBox.Show("Silmek için bölüm seçmelisiniz.");
                return;
            }
            var bolum_id = Convert.ToInt32(seciliBolum.Cells[0].Value);
            Db.bolumu_sil(bolum_id);
            bolumleri_yukle();
        }
    }
}
