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
            FilaDePersona.Recorrer(tvArbol);
            FilaDePersona.Recorrer(cmbCodigo);

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

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FilaDePersona.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            FilaDePersona.RecorrerInOrden(dgvArbol);
            FilaDePersona.Recorrer(tvArbol);
            FilaDePersona.Recorrer(cmbCodigo);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                FilaDePersona.ExportarIn(dgvArbol);
            }
            else
            {
                if (optPreOrden.Checked)
                {
                    FilaDePersona.ExportarPre(dgvArbol);
                }
                else
                {
                    if (optPostOrden.Checked)
                    {
                        FilaDePersona.ExportarPost(dgvArbol);
                    }
                    else
                    {
                        MessageBox.Show("Selecciona, pa");
                    }
                }
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            FilaDePersona.Equilibrar();
            FilaDePersona.RecorrerInOrden(dgvArbol);
            FilaDePersona.Recorrer(tvArbol);
            FilaDePersona.Recorrer(cmbCodigo);
        }
    }
}
