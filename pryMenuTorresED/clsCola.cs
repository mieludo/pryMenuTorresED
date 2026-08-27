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

        public void Eliminar()
        {
            if (primero != null)
            {
                primero = primero.siguiente;
            
                if (primero == null)
                {
                    ultimo = null;
                }
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

        public void Recorrer(DataGridView dgvLista)
        {
            clsNodo aux = primero;
            dgvLista.Rows.Clear();
            while (aux != null)
            {
                dgvLista.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.siguiente;
            }
        }
    }
}
