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
    public partial class frmClientesDeudore : Form
    {
        public frmClientesDeudore()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();

        private void frmClientesDeudore_Load(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvConsultaDatos);
            lblCantC.Text= x.CantidadClientes().ToString();
            lblTot.Text = x.DeudaClientes().ToString();
            lblProm.Text = x.PromedioDeuda().ToString();
        }
    }
}
