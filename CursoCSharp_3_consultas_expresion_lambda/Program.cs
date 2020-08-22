using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp_3_consultas_expresion_lambda {
    class Program {
        static void Main(string[] args) {
            List<Libro> libros = Libro.GetLibros();

            // usando consultas linq
            var linq = from l in libros
                       select l.Titulo;

            // usando expresiones lambda
            var titulos = libros.Select(libro => libro.Titulo);
            var ISBNs = libros.Select(libro => libro.ISBN);

            var fechaSalida = libros.Where(libro => libro.FechaSalida > DateTime.Now.AddYears(-2))
                    .Select(libro => libro.Titulo);

            var tituloCorto = libros.Where(libro => libro.Titulo.Length < 10)
                .Select(libro => libro.Titulo);

            var claseAnonima = libros.Select(libro => new {
                Titulo2 = libro.Titulo,
                FechaAuxiliar = libro.FechaSalida,
                PropiedadInventada = "valor inventada"
            });

            foreach (var item in claseAnonima) {
                Console.WriteLine($"valor titulo2 : {item.Titulo2} valor fecha: {item.FechaAuxiliar} valor inventado {item.PropiedadInventada}");
            }

            Console.ReadKey();
        }
    }
}
