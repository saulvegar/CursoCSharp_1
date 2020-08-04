using System;
using System.Collections;

namespace CursoCSharp_5_hashtable {
    class Program {
        static void Main(string[] args) {
            Hashtable hashtable = new Hashtable();

            // Añadir valores
            hashtable.Add("Alejandro", 1.22);
            hashtable.Add("Rodrigo", 5.21);
            hashtable.Add("Miriam", 9.62);

            // recorriendo Hasstable
            foreach (DictionaryEntry item in hashtable) {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            // Obtener valor del hastable
            var valor = hashtable["Alejandro"];

            Console.WriteLine(valor);

            Console.ReadLine();

            // Cuantos elementos
            var cuantos = hashtable.Count;

            // buscar
            if (hashtable.ContainsKey("Alejandro")) {

            }

            if (hashtable.ContainsValue(9.62)) {

            }

            // Eliminar
            hashtable.Remove("Alejandro");

            // recorriendo Hashtable
            foreach (DictionaryEntry item in hashtable) {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            Console.ReadLine();

            // Limpiar
            hashtable.Clear();

            // recorriendo Hashtabe
            foreach (DictionaryEntry item in hashtable) {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            Console.ReadLine();
        }
    }
}
