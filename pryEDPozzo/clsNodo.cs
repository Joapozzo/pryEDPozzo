using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDPozzo
{
    internal class clsNodo
    {
        //Propiedades
        private Int32 cod;
        private String nom;
        private String tra;

        private clsNodo sig;
        private clsNodo ant;

        public Int32 Codigo
        { 
            get { return cod; } 
            set { cod = value; } 
        }

        public String Nombre
        { 
            get { return nom; } 
            set { nom = value; } 
        }

        public string Tramite
        { 
            get { return tra; } 
            set { tra = value; } 
        }

        public clsNodo Siguiente
        { 
            get { return sig; } 
            set { sig = value; } 
        }

        public clsNodo Anterior
        { 
            get { return ant; } 
            set { ant = value; } 
        }

        public clsNodo Izquierda
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Derecha 
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
