using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPozzo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola vCola = new frmCola();
            vCola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila vPila = new frmPila();
            vPila.ShowDialog();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrolador vDatos = new frmDatosDesarrolador();
            vDatos.ShowDialog();
        }
    }
}
