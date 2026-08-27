using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    public partial class frmPila : Form
    {
        clsPila objPila = new clsPila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objPila.Agregar(objNodo);

            objPila.Recorrer(lstPila);
            objPila.Recorrer(dgvDatos);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.primero != null)
            {
                txtCodigoDos.Text = objPila.primero.Codigo.ToString();
                txtNombreDos.Text = objPila.primero.Nombre;
                txtTramiteDos.Text = objPila.primero.Tramite;
                objPila.Eliminar();

                objPila.Recorrer(lstPila);
                objPila.Recorrer(dgvDatos);
            }
            else
            {
                MessageBox.Show("La pila está vacía. No hay elementos para eliminar.", "Pila vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
