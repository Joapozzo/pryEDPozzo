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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila FilaDePersona = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersona.Agregar(ObjNodo);
            FilaDePersona.Recorrer(dgvPila);
            FilaDePersona.Recorrer(lstPila);
            FilaDePersona.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersona.Primero != null)
            {
                lblCodigoEliminar.Text = FilaDePersona.Primero.Codigo.ToString();
                lblNombreEliminar.Text = FilaDePersona.Primero.Nombre;
                lblTramiteEliminar.Text = FilaDePersona.Primero.Tramite;
                FilaDePersona.Eliminar();
                FilaDePersona.Recorrer(dgvPila);
                FilaDePersona.Recorrer(lstPila);
                FilaDePersona.Recorrer();
            }
            else
            {
                lblCodigoEliminar.Text = "";
                lblNombreEliminar.Text = "";
                lblTramiteEliminar.Text = ""
                ;
            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }
    }
}
