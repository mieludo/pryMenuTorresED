using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple ListaSimple = new clsListaSimple();
        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                clsNodo Persona = new clsNodo();
                Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
                Persona.Nombre = txtNombre.Text;
                Persona.Tramite = txtTramite.Text;

                ListaSimple.Agregar(Persona);
                LosRecorrer();
                limpiarTodo();

            }
            

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
            ListaSimple.Recorrer(cbxCodigo);
            ListaSimple.Recorrer(dgvDatos);
            ListaSimple.Recorrer(lstPila);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbxCodigo.SelectedItem != null)
            {
                try
                {
                    ListaSimple.Eliminar(
                        Convert.ToInt32(cbxCodigo.SelectedItem)
                    );

                    MessageBox.Show("Se eliminó correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex);
                }
            }
            else
            {
                MessageBox.Show(
                    "No se ha seleccionado ningún valor a eliminar."
                );
            }

            limpiarTodo();
        }
    }
}
