using ExtensionsMetods;
using System;

namespace CursoCSharp_11_metodosExtension {
    class Program {
        static void Main(string[] args) {
            //string ejemplo = "Hola";

            string s = "Hello Extension Methods";
            int i = s.WordCount();
        }
    }
}
