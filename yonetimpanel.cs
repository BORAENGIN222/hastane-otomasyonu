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
    public partial class yonetimpanel : Form
    {
        public yonetimpanel()
        {
            InitializeComponent();
        }

        private void buttonBolumKaydi_Click(object sender, EventArgs e)
        {

            BolumKayit bolumKayit = new BolumKayit();
            bolumKayit.ShowDialog();
        }

        private void buttonDoktorKayit_Click(object sender, EventArgs e)
        {

            doktorkayit doktorkayit = new doktorkayit();
            doktorkayit.ShowDialog();
        }
    }
}
