﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_8_clases_abstractas {
    public abstract class Clase : ClaseAbstracta {
        public override int Sumar(int i, int z) {
            return i + z;
        }

        public abstract override int Restar(int i, int z);
    }
}
