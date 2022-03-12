using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Ahmet");
            dictionary.Add(2, "Kübra");
            dictionary.Add(3, "Tunahan");
            dictionary.Add(4, "Melih");
            dictionary.Add(5, "Murat");
            dictionary.Add(6, "Ezgi");

            Console.WriteLine("Eklenen elemanlar:");

            foreach (var ekleme in dictionary)
            {

                Console.WriteLine(ekleme);

            }

        }
    }
}
