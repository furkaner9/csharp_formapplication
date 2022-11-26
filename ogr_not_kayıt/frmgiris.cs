namespace ogr_not_kayıt
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        frmogrnidetay frm = new frmogrnidetay();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
       
        }
    }
}