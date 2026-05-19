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
    public partial class frmListadoOrdenadoClientes : Form
    {
        public frmListadoOrdenadoClientes()
        {
            InitializeComponent();
        }

        private void frmListadoOrdenadoClientes_Load(object sender, EventArgs e)
        {

        }
        clsArchivoClientes x = new clsArchivoClientes();

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            x.Listar(dgvListar);
        }

        private void radCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {
                x.OrdenarArchivo();
                x.Listar(dgvListar);
            }
        }

        private void radLimite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLimite.Checked)
            {
                x.OrdenarPorLimite();
                x.Listar(dgvListar));
            }
        }

        private void radDeuda_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeuda.Checked)
            {
                x.OrdenarPorDeuda();
                x.Listar(dgvListar));
            }
        }
    }
}
