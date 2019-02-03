using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaProg4.Formularios;

namespace SistemaProg4
{
    public partial class mdi_Sistema : Form
    {
        public mdi_Sistema()
        {
            InitializeComponent();
        }

        private void iTBISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ITBIS miForm = new frm_ITBIS();
            miForm.MdiParent = this;
            miForm.Show();
        }
        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProducto miForm = new frmProducto();
            miForm.MdiParent = this;
            miForm.Show();
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mdi_Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
