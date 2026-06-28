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
        public void Grabar(string cod, string nombre, string lim, string deu)
        {
            //Escribe texto linea por linea
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nombre);
            AD.Write(";");
            AD.Write(lim);
            AD.Write(";");
            AD.Write(deu);
            AD.WriteLine();

            AD.Close();
            AD.Dispose();
        }

        //LISTAR LOS CLIENTES EN UNA GRILLA:
        public void Listar(DataGridView Grilla)
        {
            if (!File.Exists(NombreArchivo))
            { 
                return; 
            }
            string DatosLeidos;
            string[] VecDatos;
            //Se necesita un vector para recorrer un archivo cvs

            //Lee texto linea por linea
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();//Lee una linea completa
            Grilla.Rows.Clear();
           
            while (DatosLeidos != null)
            {
                //Separa los datos del cliente
                VecDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[3], VecDatos[2]);
                DatosLeidos = AD.ReadLine();//Pasa a la linea siguiente
            }
            AD.Close();
            AD.Dispose();
        }

        //LABEL CANTIDAD DE CLIENTES:
        public Int32 CantidadClientes()
        {
            if (!File.Exists(NombreArchivo))
            {
                return 0;
            }

            string DatosLeidos;
            Int32 C = 0;//Contador
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

        //LABEL TOTAL DEUDA:
        public Decimal DeudaClientes()
        {
            if (!File.Exists(NombreArchivo))
            {  
                return 0;
            }    

            //Declara vector para guardar los datos
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                //Suma las deudas
                Total = Total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return Total;
        }

        //LABEL PROMEDIO DEUDA:
        public Decimal PromedioDeuda()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            Int32 C = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            if (C == 0)//Por si no hay clientes
            {
                return 0;
            }
            return Total / C;//Promedio
        }
        
        //REPORTE
        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] VecDatos;

            StreamWriter Reporte = new StreamWriter("Reporte.csv", false, new System.Text.UTF8Encoding(true));
            Reporte.WriteLine("Listado de Clientes");
            Reporte.WriteLine("");
            Reporte.WriteLine("Código;Nombre;Límite;Deuda");

            //Se abre Clientes.csv para leer los datos y cargarlos en Reporte.csv
            StreamReader AD = new StreamReader(NombreArchivo);

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
                Reporte.Write(VecDatos[3]);
                Reporte.Write(";");
                Reporte.WriteLine(VecDatos[2]);

                DatosLeidos = AD.ReadLine();
                cantidad++;
                total = total + Convert.ToDecimal(VecDatos[2]);
            }
            Reporte.WriteLine();
            Reporte.Write("Total de Deudas:;;");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de clientes:;;");
            Reporte.WriteLine(cantidad);
            Reporte.Write("Promedio de Deuda:;;");
            Reporte.WriteLine(total / cantidad);
            Reporte.Close();
            Reporte.Dispose();
        }

        private RegClientes[] VecClientes = new RegClientes[1500];
        private Int32 IND = 0;//Cantidad de clientes cargados

        private struct RegClientes//Todos los datos, moverlos y compararlos
        {
            public Int32 Cod;
            public String Nom;
            public Decimal Deu;
            public Decimal Lim;
        }



        private void CargarVector()//Para ordenar
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            IND = 0;
            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                //IND = Posicion del vector
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

        private void OrdenarVector()//Para ordenar clientes por CODIGO
        {
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1; i++)
                {
                    //Si el elemento es MAYOR que el siguiente INTERCAMBIAR
                    if (VecClientes[i].Cod > VecClientes[i + 1].Cod)
                    {
                        aux = VecClientes[i]; //Guarda el actual
                        VecClientes[i] = VecClientes[i + 1]; //El siguiente pasa adelante
                        VecClientes[i + 1] = aux; //El actual pasa atras
                    }
                }
            }

        }
        private void ReescribirArchivo()//Sobreescribe con los datos ordenados del vector
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);
            for (Int32 i = 0; i < IND; i++)
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

        //ORDENAR
        public void OrdenarArchivo()
        {
            CargarVector();//LEE EL ARCHIVO:VECTOR
            OrdenarVector();//ORDENA EL VECTOR
            ReescribirArchivo();//ESCRIBE EL VECTOR:ARCHIVO
        }


        //LISTAR DEUDORES:
        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {

                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) > 0)//Deuda
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[3], VecDatos[2]);
          
                }
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        //LABEL TOTAL DEUDA:
        public Decimal DeudaDeudores()
        {
            if (!File.Exists(NombreArchivo)) return 0;
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) > 0)
                    Total = Total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return Total;
        }

        //LABEL PROMEDIO DEUDORES Y CANTIDAD DEUDORES:
        public Decimal PromedioDeudores()
        {
            if (!File.Exists(NombreArchivo))
            {
                return 0;
            }
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            Int32 C = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) > 0)
                {
                    Total = Total + Convert.ToDecimal(VecDatos[2]);
                    C++;
                }
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            if (C == 0) return 0;
            return Total / C;
        }
        

        //ORDENAR:
        public void OrdenarArchivoDes()
        {
            CargarVector();
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++)
                for (Int32 i = 0; i < IND - 1; i++)
                    if (VecClientes[i].Cod < VecClientes[i + 1].Cod)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
            ReescribirArchivo();
        }

        public void OrdenarPorDeuda()
        {
            CargarVector();
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++)
                for (Int32 i = 0; i < IND - 1; i++)
                    if (VecClientes[i].Lim > VecClientes[i + 1].Lim)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
            ReescribirArchivo();
        }

        public void OrdenarPorDeudaDes()
        {
            CargarVector();
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++)
                for (Int32 i = 0; i < IND - 1; i++)
                    if (VecClientes[i].Lim < VecClientes[i + 1].Lim)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
            ReescribirArchivo();
        }
        public void OrdenarPorLimite()
        {
            CargarVector();
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++)
                for (Int32 i = 0; i < IND - 1; i++)
                    if (VecClientes[i].Deu > VecClientes[i + 1].Deu)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
            ReescribirArchivo();
        }

        public void OrdenarPorLimiteDes()
        {
            CargarVector();
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++)
                for (Int32 i = 0; i < IND - 1; i++)
                    if (VecClientes[i].Deu < VecClientes[i + 1].Deu)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
            ReescribirArchivo();
        }

    }
}

