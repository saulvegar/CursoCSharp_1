using System;
using System.IO;
using System.Text;

namespace CursoCSharp_6_escribir_datos_archivo {
    class Program {
        static void Main(string[] args) {
            FileStream fs = new FileStream("miArchivo.txt", FileMode.Create);

            string cadena = "Esto es una cadena de ejemplo";

            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fs.Close();
        }
    }
}
