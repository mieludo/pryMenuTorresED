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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble ListaDoble = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();

            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ListaDoble.Agregar(Persona);

            LosRecorrer();
            limpiarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbxCodigo.SelectedItem != null)
            {
                try
                {
                    ListaDoble.Eliminar(Convert.ToInt32(cbxCodigo.SelectedItem));

                    MessageBox.Show("Se eliminó correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex);
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún valor para eliminar.");
            }

            limpiarTodo();
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            cbxCodigo.Text = "";

            LosRecorrer();
        }

        private void LosRecorrer()
        {
            ListaDoble.Recorrer(cbxCodigo);
            ListaDoble.Recorrer(dgvDatos);
            ListaDoble.RecorrerDes(lstListaDoble);
        }
    }
}
