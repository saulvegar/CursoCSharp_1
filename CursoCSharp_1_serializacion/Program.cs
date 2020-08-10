using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace CursoCSharp_1_serializacion {
    class Program {
        static void Main(string[] args) {

            List<Todos> ejemplo1 = new List<Todos>();

            EjemploClase ejemplo;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://jsonplaceholder.typicode.com/todos");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream)) {
                var json = reader.ReadToEnd();
                ejemplo1 = JsonConvert.DeserializeObject<List<Todos>>(json);
                Console.WriteLine("El ejemplo es: " + ejemplo1.First().title);
            }

            var serializado = JsonConvert.SerializeObject(ejemplo1);
        }
    }
}
