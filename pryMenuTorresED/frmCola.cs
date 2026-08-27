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
    public partial class frmCola : Form
    {
        clsCola Cola = new clsCola();
        public frmCola()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Cola.Agregar(objNodo);
            Cola.Recorrer(lbLista);
            Cola.Recorrer(dgvLista);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

            txtCodigo.Focus();
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
