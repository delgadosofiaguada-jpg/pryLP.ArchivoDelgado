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
    public partial class frmDatosDesarrollador : Form
    {
        public frmDatosDesarrollador()
        {
            InitializeComponent();
        }
        clsArchivoClientes x=new clsArchivoClientes();
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            x.Grabar(txtCodigo.Text,txtNombre.Text,txtDeuda.Text,txtLimite.Text);
            MessageBox.Show("Datos Grabados");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtLimite.Text = "";
            txtDeuda.Text = "";
        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {

        }
    }
}
