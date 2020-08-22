using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp_2_introduccion_consultas_linq {
    class Program {
        static void Main(string[] args) {
            List<Libro> libros = Libro.GetLibros();

            var tituloslibros =
                from l in libros
                select l.Titulo;

            foreach (var titulo in tituloslibros) {
                Console.WriteLine(titulo);
            }

            Console.ReadKey();
        }
    }
}
