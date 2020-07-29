using System;

namespace CursoCSharp_2_variables {
    class Program {
        static void Main(string[] args) {
            string mensaje = Console.ReadLine();
            string hola = null;

            int edad = default(int); // 0
            int? altura = null;
            bool verdadero = default(bool); // false


            edad = edad + 5;

            if (altura == null) {
                // Hacer algo
            }

            DateTime? fecha = new DateTime();
            fecha = null;
            int? dia = fecha?.Day;


            Console.Write(edad);
            Console.ReadLine();

            var variable = edad + "Hola";
        }
    }
}
