using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    internal class clsPila
    {
       
            private clsNodo Primero;
            
            public clsNodo primero
        { get { return Primero; }
            
        }
        public void Agregar(clsNodo Nuevo)
            {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar()
            {
                if (Primero != null)
                {
                    Primero = Primero.siguiente;
                }
            }

            public void Recorrer(ListBox lst)
            {
                clsNodo aux = Primero;
                lst.Items.Clear();

                while (aux != null)
                {
                    lst.Items.Add($"{aux.Codigo} {aux.Nombre} {aux.Tramite}");
                    aux = aux.siguiente;
                }
            }

            public void Recorrer(DataGridView dgv)
            {
                clsNodo aux = Primero;
                dgv.Rows.Clear();

                while (aux != null)
                {
                    dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                    aux = aux.siguiente;
                }
            }
        }
    }

