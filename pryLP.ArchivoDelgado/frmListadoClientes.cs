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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes x=new clsArchivoClientes();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvConsultaDatos);
            lblCantC.Text = x.CantidadClientes().ToString();
            lblTot.Text = x.DeudaClientes().ToString();
            lblProm.Text = x.PromedioDeuda().ToString();

        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente");
        }

        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
            x.Listar(dgvConsultaDatos);
            lblCantC.Text = x.CantidadClientes().ToString();
            lblTot.Text = x.DeudaClientes().ToString();
            lblProm.Text = x.PromedioDeuda().ToString();

        }
    }
}
