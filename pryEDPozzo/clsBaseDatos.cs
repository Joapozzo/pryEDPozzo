using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace pryEDPozzo
{
    internal class clsBaseDatos
    {
        //Conectar
        private OleDbConnection conexion = new OleDbConnection();
        //Usar comandos y acciones
        private OleDbCommand comando = new OleDbCommand();
        //Adaptador que lleva la tabla a una memoria virtual
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        //private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView Grilla, string varInstruccionSQL) 
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                //Contiene la tabla de la BS y la lleva a la memoria virtual
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Resultado");

                //Muestro en grilla la tabla seleccionada
                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
    }
}
