using System;
using System.Collections.Generic;

namespace CursoCSharp_6_polimorfismo {
    class Program {
        static void Main(string[] args) {
            Gato gato = new Gato();
            gato.HacerRuido();

            Perro perro = new Perro();
            perro.HacerRuido();

            Lobo lobo = new Lobo();
            lobo.HacerRuido();

            Console.Read();


            List<Animal> zoo = new List<Animal>();
            zoo.Add(gato);
            zoo.Add(perro);
            zoo.Add(lobo);

            foreach (var animal in zoo) {
                animal.HacerRuido();
            }

            Console.Read();
        }
    }
}
