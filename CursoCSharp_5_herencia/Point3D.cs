using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_5_herencia {
    class Point3D : Point, IEjemplo {
        public int Z { get; set; }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetZ(int value) {
            if (value < 30)
                Z = value;
            else
                throw new ArgumentOutOfRangeException();
        }

        public int GetZ() {
            return Z;
        }
    }
}
