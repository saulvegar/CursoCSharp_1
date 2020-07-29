using System;

namespace CursoCSharp_ejercicios {
    class Program {
        static void Main(string[] args) {
            int numero1 = 10;
            double pi = 3.1416;
            long numeroGrande = 1000000;

            double suma = numero1 + pi + numeroGrande;
            Console.WriteLine("suma: " + suma);


            Console.ReadKey();
            Console.Write("Ingresa el numero 1");
            int numeroA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el numero 2");
            int numeroB = Convert.ToInt32(Console.ReadLine());
            

            if (numeroA > numeroB) {
                Console.WriteLine("El numero: " + numeroA + " es mayor que el numero " + numeroB);
            } else {
                Console.WriteLine("El numero: " + numeroB + " es mayor que el numero " + numeroA);
            }


            Console.ReadKey();
            Console.WriteLine("Ingresa el día de la semana");
            string dia = Console.ReadLine();

            switch(dia) {
                case "Sabado":
                    Console.WriteLine("Es fin de semana");
                    break;
                case "Domingo":
                    Console.WriteLine("Es fin de semana");
                    break;
                default:
                    Console.WriteLine("No es fin de semana");
                    break;
            }





            for (int i = 1; i <= 100; i++) {
                Console.WriteLine(i);
            }

            int j = 1;
            while(j <= 100) {
                Console.WriteLine(j);
                j++;
            }


            for(int i = 1; i <= 100; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                } 
            }
        }
    }
}
