using System;

namespace CursoCSharp_4_tipos_dinamicos {
    class Program {
        static void Main(string[] args) {
            ExampleClass ec = new ExampleClass();
            // ec.exampleMethod1(10, 4);

            dynamic dynamic_ec = new ExampleClass();
            dynamic_ec.exampleMethod(10, 4);

            dynamic_ec.someMethod("some argument", 7, null);
            dynamic_ec.noexistentMethod();

            dynamic d = 8;
            var suma = d + 4;
        }
    }

    class ExampleClass {
        public ExampleClass() {}
        public ExampleClass(int v) {}
        public void exampleMethod(int i) {}
        public void exampleMethod2(string str) {}
    }
}
