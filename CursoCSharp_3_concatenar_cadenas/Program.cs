using System;

namespace CursoCSharp_3_concatenar_cadenas {
    class Program {
        static void Main(string[] args) {
            string superheore = "Superman";
            string procedencia = "Kripton";
            string superpoder = "super fuerza";

            string todosDatos = superheore + " procede de " + procedencia + " y tiene " + superpoder;

            string todosDatosConcat = string.Concat(superheore, " procede de ", procedencia, " y tiene ", superpoder);
            string todosDatosConcat2 = string.Concat(superheore, superpoder);


            string todosDatosInterpolation = $"{superheore} procede de {procedencia} y tiene {superpoder}";
            string ejemploInterpolacion = $"{3 + 5} es igual a 8?";

            //Console.WriteLine(todosDatos);
            //Console.ReadLine();

            //Console.WriteLine(todosDatosConcat);
            //Console.WriteLine(todosDatosConcat2);

            Console.WriteLine(todosDatosInterpolation);
            Console.WriteLine(ejemploInterpolacion);
            Console.ReadLine();
        }
    }
}
