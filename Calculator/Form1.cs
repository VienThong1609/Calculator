namespace Calculator
{
    public partial class TinhToan : Form
    {
        public TinhToan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TinhToan_Load(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketQua = a + b;
            txtKq.Text = ketQua.ToString();
        }
    }
}