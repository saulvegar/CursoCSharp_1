using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_1_interfaces {
    public class Car : IEquatable<Car>, IComparacion {
        public bool Equals(Car obj) {
            throw new NotImplementedException();
        }

        public int EsIgual(int numero) {
            throw new NotImplementedException();
        }

        public int EsIgualCoche(int numero) {
            throw new NotImplementedException();
        }
    }
}
