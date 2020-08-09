using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_6_metodos {
    class Clase {
        // Campo o Propiedades
        public int Campo;
        public string Nombre { get; set; }
        public readonly string Idetificador = "XX";

        // Constructor
        public Clase() {

        }

        // Metodo
        public void Calcular(int edad) {
            // Operación de nuestro metodo
            Console.WriteLine(edad + 15);
        }

        // Metodo
        public int Sumar(int numero, int numero2) {
            return numero + numero2;
        }
    }
}
