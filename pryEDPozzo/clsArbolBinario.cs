using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPozzo
{
    internal class clsArbolBinario
    {
        private clsNodo Inicio;

        public clsNodo Raiz
        { 
            get { return Inicio; }
            set { Inicio = value; }
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierda;
                else Aux = Aux.Derecha;
            }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo Anterior = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    Anterior = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierda;
                    }
                    else
                    {
                        Aux = Aux.Derecha;
                    }
                }
                if (Nvo.Codigo < Anterior.Codigo)
                {
                    Anterior.Izquierda = Nvo;
                }
                else
                {
                    Anterior.Derecha = Nvo;
                }
            }
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol();
        }

        public void Eliminar(codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i ­ 1);
        }

        private void EquilibrarArbol(ini , fin )
        {
            m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m ­ 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

        public void RecorrerInOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Dgv, R.Izquierda);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) InOrdenAsc(Dgv, R.Derecha);
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) InOrdenAsc(Dgv, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(Dgv, R.Derecha);
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Dgv, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(Dgv, R.Derecha);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

    }


}
