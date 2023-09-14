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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble FilaDePersona = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersona.Agregar(ObjNodo);
            FilaDePersona.Recorrer(dgvListaDoble);
            FilaDePersona.Recorrer(lstListaDoble);
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
                FilaDePersona.Recorrer(dgvListaDoble);
                FilaDePersona.Recorrer(lstListaDoble);
                FilaDePersona.Recorrer(cmbCodigo);
                FilaDePersona.Recorrer();
            }
            else
            {
                MessageBox.Show("No hay elementos en la lista, capo");
            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersona.Recorrer(dgvListaDoble);
            FilaDePersona.Recorrer(lstListaDoble);
            FilaDePersona.Recorrer(cmbCodigo);

        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersona.RecorrerDes(dgvListaDoble);
            FilaDePersona.RecorrerDes(lstListaDoble);
            FilaDePersona.RecorrerDes(cmbCodigo);
        }
    }
}
