using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;


namespace pryLP.ArchivoDelgado
{
    internal class clsArchivoClientes
    {

        public string NombreArchivo = "Clientes.csv";
        public void Grabar(string cod, string nombre, string deu, string lim)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nombre);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.Write(lim);
            AD.WriteLine();

            AD.Close();
            AD.Dispose();
        }
        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos;
            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {

                VecDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }
            //cerrar
            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadClientes()
        {
            string DatosLeidos;
            Int32 C = 0;
            //ABRIR
            StreamReader AD = new StreamReader(NombreArchivo);
            //LEER
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                C++;
                DatosLeidos = AD.ReadLine();
            }
            //CERRAR
            AD.Close();
            AD.Dispose();



            return C;
        }
        public Decimal DeudaClientes()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;

            //ABRIR
            StreamReader AD = new StreamReader(NombreArchivo);
            //LEER
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }

            //CERRAR
            AD.Close();
            AD.Dispose();
            return Total;

        }

        public Decimal PromedioDeuda()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            Int32 C = 0;
            //ABRIR
            StreamReader AD = new StreamReader(NombreArchivo);
            //LEER
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }

            //CERRAR
            AD.Close();
            AD.Dispose();
            return Total / C;

        }

        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos;
            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {

                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToInt32(VecDatos[2]) > 0)
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
          
                }
                DatosLeidos = AD.ReadLine();
            }
            //cerrar
            AD.Close();
            AD.Dispose();
        }

    }
}

