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
    public partial class doktorpanel : Form
    {
        public doktorpanel()
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
            foreach (DataRow bolum in kayitli_doktorlar)
            {
                int doktor_id = Convert.ToInt32(bolum[0]);
                string doktor_adi = bolum[1].ToString();
                comboBoxDoktor.Items.Add(new ComboboxItem(doktor_adi, doktor_id));
                if (comboBoxDoktor.Items.Count > 0)
                {
                    comboBoxDoktor.SelectedIndex = 0;
                }
            }
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doktorpanel_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboboxItem secili_doktor_item = comboBoxDoktor.SelectedItem as ComboboxItem;
            if (secili_doktor_item == null)
            {
                MessageBox.Show("Doktor seçmelisin.");
                return;
            }
            var doktor_id = secili_doktor_item.Value;

            dataGridViewRandevular.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            dataGridViewRandevular.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            var dataset = Db.randevulari_getir(doktor_id, comboBox1.SelectedIndex);
            dataGridViewRandevular.DataSource = dataset.Tables[0];
        }
    }
}
