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
            x.Listar(dgvListar);
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void cmdListar_Click(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {
                x.OrdenarArchivo();
                x.Listar(dgvListar);
            }
            else if (rbLimite.Checked)
            {
                x.OrdenarPorLimite();
                x.Listar(dgvListar);
            }
            else if (rbDeuda.Checked)
            {
                x.OrdenarPorDeuda();
                x.Listar(dgvListar);
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de ordenamiento antes de listar");
            }
        }
    }
}
