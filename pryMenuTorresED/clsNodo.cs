using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMenuTorresED
{
    internal class clsNodo
    {
        private int codigo;
        private string nombre;
        private string tramite;

        public clsNodo siguiente;
        public clsNodo anterior;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tramite { get => tramite; set => tramite = value; }
    }
}
