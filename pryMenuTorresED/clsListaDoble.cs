using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    internal class clsListaDoble
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public clsNodo Primero
        {
            get => primero;
            set => primero = value;
        }

        public clsNodo Ultimo
        {
            get => ultimo;
            set => ultimo = value;
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.siguiente = Primero;
                    Primero.anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.siguiente = Nuevo;
                        Nuevo.anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;

                        while (aux.Codigo < Nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                        }

                        ant.siguiente = Nuevo;
                        Nuevo.siguiente = aux;
                        aux.anterior = Nuevo;
                        Nuevo.anterior = ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.siguiente;
                    Primero.anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.anterior;
                        Ultimo.siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;

                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                        }

                        ant.siguiente = aux.siguiente;
                        aux = aux.siguiente;
                        aux.anterior = ant;
                    }
                }
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            clsNodo aux = Primero;
            grilla.Rows.Clear();

            while (aux != null)
            {
                grilla.Rows.Add(
                    aux.Codigo,
                    aux.Nombre,
                    aux.Tramite
                );

                aux = aux.siguiente;
            }
        }

        public void RecorrerDes(ListBox lista)
        {
            clsNodo aux = Ultimo;
            lista.Items.Clear();

            while (aux != null)
            {
                lista.Items.Add(
                    aux.Codigo + " - " +
                    aux.Nombre + " - " +
                    aux.Tramite
                );

                aux = aux.anterior;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }
    }
}

