using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLP.ArchivoDelgado
{
    internal class clsArchivoClientes
    {

        public string NombreArchivo = "Clientes.csv";
        public void Grabar(string cod,string nombre,string deu,string lim)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
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
            StreamReader AD= new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos!=null)
            {
                
                VecDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }
            //cerrar
            AD.Close();
            AD.Dispose();
        }
    }
}
