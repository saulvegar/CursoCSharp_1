using System;

namespace CursoCSharp3_funciones {
    class Program {
        static void Main(string[] args) {

            string saludo = Saludo("Pedro", "Lopez");
            
        }

        // Se le pasan parametros y devuelve un valor
        public static string Saludo(string nombre, string apellidos) {
            return "Mi nombre es: " + nombre + " " + apellidos;
        }

        // Que solo ejecutan codigo
        public static void Metodo() {
            Console.WriteLine("valor");
        }

        // Devuelve un valor pero no recibe valores
        public static int FuncionSinParametros() {
            return 7 + 9;
        }
        
        // Metodo, que no devuelve valor y recibe parametros
        public static void MedodoConParametros(string nombre, string apellido) {
            Console.WriteLine(nombre + " " + apellido);
        }
    }
}
