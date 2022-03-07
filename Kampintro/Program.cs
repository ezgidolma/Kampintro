using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            bool Sistemegirisyapmismi = true;
            double dolarDun = 7.56;
            double dolarBugun = 7.38;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış butonu");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (Sistemegirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            double dolardun = 7.56;
            double dolarbugun = 7.88;
        }
    }
}
