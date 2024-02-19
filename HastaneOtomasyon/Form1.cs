namespace HastaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYonetimPanel_Click(object sender, EventArgs e)
        {
            yonetimgiris yonetimgiris = new yonetimgiris();
            yonetimgiris.ShowDialog();
        }

        private void buttonDoktorPanel_Click(object sender, EventArgs e)
        {
            doktorgiris doktorgiris = new doktorgiris();
            doktorgiris.ShowDialog();
        }

        private void buttonHastaPanel_Click(object sender, EventArgs e)
        {

            hastakayit hastakayit = new hastakayit();
            hastakayit.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}