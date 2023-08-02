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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void bntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frm1();
            frm1.ShowDialog();
        }

        private void retanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAreaRetangulo = new frmAreaRetangulo();
            frmAreaRetangulo.ShowDialog();
        }
    }
}
