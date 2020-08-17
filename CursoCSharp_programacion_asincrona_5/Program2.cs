using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp_programacion_asincrona_5 {
    public class Cafe {

    }

    public class Huevos {

    }

    public class Bacon {

    }

    public class Tostada {

    }

    public class Zumo {

    }

    class Program2 {
        static async Task Main(string[] args) {
            Cafe cup = HacerCafe();
            Console.WriteLine("cafe listo");
            var eggsTask = FreirHuevos(2);
            var baconTask = FreirBacon(3);
            var toastTask = HacerTostadasConMantequillaYJamon(2);

            var allTasks = new List<Task> { eggsTask, baconTask, toastTask };

            while (allTasks.Any()) {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggsTask) {
                    Console.WriteLine("huevos listos");
                    allTasks.Remove(eggsTask);
                    var eggs = await eggsTask;
                } else if (finished == baconTask) {
                    Console.WriteLine("bacon listo");
                    allTasks.Remove(baconTask);
                    var bacon = await baconTask;
                } else if (finished == toastTask) {
                    Console.WriteLine("tostadas preparadas");
                    allTasks.Remove(toastTask);
                    var toast = await toastTask;
                } else
                    allTasks.Remove(finished);
            }

            Zumo oj = HacerZumo();
            Console.WriteLine("zumo en su punto");
            Console.WriteLine("desayuno preparado!");
        }

        async static Task<Tostada> HacerTostadasConMantequillaYJamon(int number) {
            var plainToast = await TostarPan(number);
            AplicarMantequilla(plainToast);
            AplicarJamon(plainToast);
            return plainToast;
        }

        public static Cafe HacerCafe() {
            return new Cafe();
        }

        public static async Task<Huevos> FreirHuevos(int numHuevos) {
            return new Huevos();
        }

        public static async Task<Bacon> FreirBacon(int numHuevos) {
            return new Bacon();
        }

        public static async Task<Tostada> TostarPan(int numHuevos) {
            return new Tostada();
        }

        public static void AplicarMantequilla(Tostada tostada) {

        }

        public static void AplicarJamon(Tostada tostada) {

        }

        public static Zumo HacerZumo() {
            return new Zumo();
        }
    }
}
