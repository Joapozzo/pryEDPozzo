﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDPozzo
{
    internal class clsNodo
    {
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;

        public Int32 Codigo
        { get { return cod; } set { cod = value; } }

        public String Nombre
        { get { return nom; } set { nom = value; } }

        public string Tramite
        { get { return tra; } set { tra = value; } }

        public clsNodo Siguiente
        { get { return sig; } set { sig = value; } }
    }
}