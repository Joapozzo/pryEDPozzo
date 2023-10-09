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
    public partial class frmBaseDatos : Form
    {
        public frmBaseDatos()
        {
            InitializeComponent();
        }

        String varSQL;
        clsBaseDatos objBaseDeDatos = new clsBaseDatos();

        private void btnSimple_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
;        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT ID,TITULO," + "FROM LIBRO" + "ORDER BY 1 DESC";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT TITULO FROM LIBRO"  + "WHERE IDIDIOMA = 2 AND" + "IDLIBRO IN" +
            "(SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3)" +
            "ORDER BY 1 ASC";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO" + "WHERE CANTIDAD >= 1";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO" + "WHERE IDAUTOR = 2"
            + "UNION" + "SELECT * FROM LIBRO" + "WHERE IDAUTOR = 5"
            + "UNION" + "SELECT * FROM LIBRO" + "WHERE IDAUTOR = 3";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO" + "WHERE IDIDIOMA"
            + "NOT IN" + "(SELECT DISTINC IDIDIOMA FROM LIBRO)" + "WHERE IDIOMA < 5";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }
    }
}
