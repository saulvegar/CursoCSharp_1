using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_8_clases_abstractas {
    public abstract class ClaseAbstracta {
        public abstract int Sumar(int i, int z);

        public virtual int Restar(int i, int z) {
            return i - z;
        }
    }
}
