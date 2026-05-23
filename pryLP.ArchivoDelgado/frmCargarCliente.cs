using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLP.ArchivoDelgado
{
    public partial class frmCargarCliente : Form
    {
        public frmCargarCliente()
        {
            InitializeComponent();
        }
        clsArchivoClientes x=new clsArchivoClientes();
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDeuda.Text == "" || txtLimite.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de cargar el cliente.", "Datos incompletos");
                return;
            }

            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Datos Grabados");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtLimite.Text = "";
            txtDeuda.Text = "";
            txtCodigo.Focus();//vuelve el cursor al txtcodigo
        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {

        }
    }
}
