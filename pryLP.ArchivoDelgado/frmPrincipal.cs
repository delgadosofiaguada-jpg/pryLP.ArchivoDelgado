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
    public partial class frmGestorClientes : Form
    {
        public frmGestorClientes()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmDatosDelDesarrollador();
            form.MdiParent = this;
            form.Show();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmListadoClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmCargarCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void listadoDeTodosLosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmClientesDeudores();
            form.MdiParent = this;
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGestorClientes_Load(object sender, EventArgs e)
        {

        }

        private void listadoOrdenadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmListadoOrdenadoClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

