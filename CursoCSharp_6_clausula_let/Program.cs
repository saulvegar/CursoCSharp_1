using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp_6_clausula_let {
    class Program {
        static void Main(string[] args) {
            List<Libro> libros = Libro.GetLibros();
            List<LibroStats> librosStats = LibroStats.GetLibrosStats();

            var TitulosLibros = from l in libros
                                join s in librosStats on l.ISBN equals s.ISBN
                                let ganancias = (l.Precio * s.Ventas)
                                select new {
                                    TituloSeleccionado = l.Titulo,
                                    Ganancias = ganancias
                                };

            foreach (var item in TitulosLibros) {
                Console.WriteLine($"Titulo {item.TituloSeleccionado} Paginas: {item.Ganancias}");
            }

            Console.ReadKey();
        }
    }
}
