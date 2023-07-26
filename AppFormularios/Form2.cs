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
    public partial class frmAreaRetangulo : Form
    {
        public frmAreaRetangulo()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Lado1 = double.Parse(txtLado1.Text);
            double Lado2 = double.Parse(txtLado2.Text);

            txtArea.Text = (Lado1 * Lado2).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtLado1.Clear();
            txtLado2.Clear();
        }
    }
}
