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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario FilaDePersona = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersona.Agregar(ObjNodo);
            FilaDePersona.RecorrerInOrden(dgvArbol);
            //FilaDePersona.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            FilaDePersona.RecorrerInOrden(dgvArbol);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            FilaDePersona.RecorrerPreOrden(dgvArbol);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            FilaDePersona.RecorrerPostOrden(dgvArbol);
        }
    }
}
