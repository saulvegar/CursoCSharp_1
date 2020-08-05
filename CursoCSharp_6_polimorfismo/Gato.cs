using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_6_polimorfismo {
    class Gato : Animal {
        public override void HacerRuido() {
            Console.WriteLine("El gato hace miiiau");
        }
    }
}
