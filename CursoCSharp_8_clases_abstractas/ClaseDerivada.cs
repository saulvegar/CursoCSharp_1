using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_8_clases_abstractas {
    class ClaseDerivada : Clase {
        public override int Restar(int i, int z) {
            return i + z;
        }
    }
}
