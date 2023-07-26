using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormularios
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnChama2_Click(object sender, EventArgs e)
        {
            Form frm2 = new frmAreaRetangulo();
            frm2.ShowDialog();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Lado = double.Parse(txtLado.Text);
            txtResultado.Text = (Lado * Lado).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLado.Clear();
            txtResultado.Clear();
        }
    }
}
