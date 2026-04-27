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
            
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmListadoClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmDatosDesarrollador();
            form.MdiParent = this;
            form.Show();
        }

        private void listadoDeTodosLosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmClientesDeudore();
            form.MdiParent = this;
            form.Show();
        }
    }
}

