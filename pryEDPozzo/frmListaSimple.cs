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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple FilaDePersona = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }

            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersona.Agregar(ObjNodo);
            FilaDePersona.Recorrer(dgvListaSimple);
            FilaDePersona.Recorrer(lstListaSimple);
            FilaDePersona.Recorrer(cmbCodigo);
            FilaDePersona.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersona.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                FilaDePersona.Eliminar(x);
                FilaDePersona.Recorrer(dgvListaSimple);
                FilaDePersona.Recorrer(lstListaSimple);
                FilaDePersona.Recorrer(cmbCodigo);
                FilaDePersona.Recorrer();
            }
            else
            {
                MessageBox.Show("No hay elementos en la lista, capo");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtTramite.Enabled = true;
            }
            else
            {
                txtTramite.Enabled = false;
            }

        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilaDePersona.Primero != null)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
