namespace MDI
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void quảnLýThôngTinĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Daily s = new Form_Daily();
            s.Show();
        }

        private void quảnLýThôngTinHàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From_Thongtin f = new From_Thongtin();
            f.Show();
        }

        private void hoáĐơnMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Mua h = new Form_Mua();
                h.Show();
        }

        private void lậpHoáĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ban k= new Form_Ban();
            k.Show();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhthu a= new FormDanhthu();
            a.Show();
        }
    }
}