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
    public partial class yonetimgiris : Form
    {
        public yonetimgiris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (textBoxSifre.Text == "yönetim123")
            {
                yonetimpanel yonetimpanel = new yonetimpanel();
                yonetimpanel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yanlış şifre girdiniz.");
            }
        }
    }
}
