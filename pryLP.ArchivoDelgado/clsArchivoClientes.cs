using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] VecDatos;

            StreamWriter Reporte = new StreamWriter("Reposrte.csv",false);
            //abrir
            Reporte.WriteLine("Listado de Clientes");
            Reporte.WriteLine("");
            Reporte.WriteLine("Código;Nombre;Límite;Deuda");
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();
            Int32 cantidad = 0;
            decimal total = 0;
            while (DatosLeidos != null)
            {

                VecDatos = DatosLeidos.Split(';');//Separa dentro del vector los datos
                Reporte.Write(VecDatos[0]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[2]);
                Reporte.Write(";");
                Reporte.WriteLine(VecDatos[3]);

                DatosLeidos = AD.ReadLine();
                cantidad++;
                total = total + Convert.ToDecimal(VecDatos[3]);
            }
            //cerrar
          
            Reporte.WriteLine();
            Reporte.Write("Total de Deudas:;;");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de clientes:;;");
            Reporte.WriteLine(cantidad);
            Reporte.Write("Promedio de Deuda:;;");
            Reporte.WriteLine(total/cantidad);
            Reporte.Close();
            Reporte.Dispose();
        }
        private struct RegClientes
        {
            public Int32 Cod;
            public String Nom;
            public Decimal Deu;
            public Decimal Lim;
        }
        private RegClientes[] VecClientes = new RegClientes[1500];
        private Int32 IND = 0;
        private void CargarVector()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            IND = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                VecClientes[IND].Cod = Convert.ToInt32(VecDatos[0]);
                VecClientes[IND].Nom = VecDatos[1];
                VecClientes[IND].Deu = Convert.ToDecimal(VecDatos[3]);
                VecClientes[IND].Lim = Convert.ToDecimal(VecDatos[2]);
                IND++;//Pasa a la siguiemte linea del vector
                DatosLeidos = AD.ReadLine();//Lee la línea
            }
            AD.Close();
            AD.Dispose();
        }
        private  void OrdenarVector()
        {
            RegClientes aux;
            for (Int32 c= 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1; i++)//Recorre el vector
                {
                    if (VecClientes[i].Cod > VecClientes[i + 1].Cod)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];//Se pisa con el dato de abajo
                        VecClientes[i + 1] = aux;//Se pisa con el dato de arriba
                    }
                }
            }
            
        }
        private void ReescribirArchivo()
        {
            StreamWriter AD =new StreamWriter(NombreArchivo, false);//false,borra todo y carga nuevos, no duplica
            for (Int32 i=0; i<IND; i++)
            {
                AD.Write(VecClientes[i].Cod);
                AD.Write(";");
                AD.Write(VecClientes[i].Nom);
                AD.Write(";");
                AD.Write(VecClientes[i].Lim);
                AD.Write(";");
                AD.Write(VecClientes[i].Deu);
                AD.WriteLine();
            }
            AD.Close();
            AD.Dispose();
        }
        
        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();
        }

    }
}

