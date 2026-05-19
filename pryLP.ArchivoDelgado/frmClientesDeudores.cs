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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();

        private void frmClientesDeudore_Load(object sender, EventArgs e)
        {
            
            x.ListarDeudores(dgvConsultaDatos);
            lblCantC.Text = (dgvConsultaDatos.Rows.Count-1).ToString();
            lblTot.Text = x.DeudaClientes().ToString();
            lblProm.Text = x.PromedioDeuda().ToString();
           
        }

        private void gbClientesDeudores_Enter(object sender, EventArgs e)
        {

        }
    }
}
