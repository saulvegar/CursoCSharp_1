using System;

namespace CursoCSharp_4_encapsulacion {
    class Program {
        static void Main(string[] args) {
            Point point = new Point();
            point.X = 5000;

            try {
                PointEncapsulado pointEnc = new PointEncapsulado();
                pointEnc.SetX(80);
                pointEnc.SetY(90);

                Console.WriteLine(pointEnc.GetX());
                Console.WriteLine(pointEnc.GetY());
            } catch(Exception ex) {
                Console.WriteLine("exception");
            }
            
        }
    }
}
