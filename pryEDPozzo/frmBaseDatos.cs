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
            varSQL = "SELECT IDLIBRO,TITULO FROM LIBRO ORDER BY 1 DESC";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE IdAutor > 10" +
                "INTERSECT" +
                "SELECT * FROM Libro WHERE IdIdioma > 5";

            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE Cantidad >= 1";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE idIdioma = 2" +
                " Union " +
                "SELECT * FROM Libro WHERE idIdioma = 7";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA NOT IN (SELECT DISTINCT IDIDIOMA FROM LIBRO WHERE IDIDIOMA < 5)";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSeleccionMulti_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE Cantidad >= 1 AND Precio > 130";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnConvulcion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM (SELECT * FROM Libro WHERE IDAUTOR = 5) AS X WHERE IDIDIOMA = 3";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
            
        }
    }
}
