using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
   

        private void ImgDolar_Click(object sender, EventArgs e)
        {
            FrmDolar dolar = new FrmDolar();
            dolar.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgEuro_Click(object sender, EventArgs e)
        {
            FrmEuro euro = new FrmEuro();
            euro.Show();
        }
    }
}
