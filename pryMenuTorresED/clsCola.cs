using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    internal class clsCola
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public clsNodo Primero { get => primero; set => primero = value; }
        public clsNodo Ultimo { get => ultimo; set => ultimo = value; }

        public void Agregar(clsNodo Nuevo) 
        {
            if (primero == null)
            { primero = Nuevo;
                ultimo = Nuevo;
            }
            else
            {
                ultimo.siguiente = Nuevo;
                ultimo = Nuevo;
            }
        }

        public void Recorrer(ListBox lbLista)

        {
            clsNodo aux = primero;

            lbLista.Items.Clear();
            
            while (aux != null)
            {
                lbLista.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.siguiente;
            }
        }


    }
}
