using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_6_polimorfismo {
    class Perro : Animal {
        public override void HacerRuido() {
            Console.WriteLine("El perro hace Guau Guau");
        }
    }
}
