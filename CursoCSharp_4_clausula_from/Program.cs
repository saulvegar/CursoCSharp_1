using System;
using System.Linq;
using System.Collections.Generic;

namespace CursoCSharp_4_clausula_from {
    class Program {
        static void Main(string[] args) {
            List<Libro> libros = Libro.GetLibros();

            var librosListado = from l in libros;
        }
    }
}
