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

            if (cbCampo.SelectedIndex == -1 || cbModo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un campo y un modo de ordenamiento");
                return;
            }

            switch (cbCampo.SelectedIndex)
            {
                case 0: // Código
                    if (cbModo.SelectedIndex == 0)
                    {
                        x.OrdenarArchivo();
                    }
                    else
                    {
                        x.OrdenarArchivoDes();
                    } 
                    break;
                case 1: // Límite
                    if (cbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorLimite();
                    }
                    else
                    {
                        x.OrdenarPorLimiteDes();
                    }
                    break;
                case 2: // Deuda
                    if (cbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorDeuda();
                    }
                    else
                    {
                        x.OrdenarPorDeudaDes();
                    }
                break;
            }

            x.Listar(dgvListar);
        }
    }
    
}
