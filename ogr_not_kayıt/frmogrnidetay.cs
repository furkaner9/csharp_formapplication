using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ogr_not_kayıt
{
    public partial class frmogrnidetay : Form
    {
        public frmogrnidetay()
        {
            InitializeComponent();
        }
        public string numara;
      private void frmogrencidetay_load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
        }
    }
}
