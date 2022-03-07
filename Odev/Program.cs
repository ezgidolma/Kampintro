using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Urunadi = "Tayt";
            urun1.Urunfiyati = 120;
            urun1.Urunpuanı = 74;
            urun1.Urunrengi = "Siyah";

            Urun urun2 = new Urun();
            urun2.Urunadi = "Crop";
            urun2.Urunfiyati = 50;
            urun2.Urunpuanı = 84;
            urun2.Urunrengi = "Beyaz";

            Urun urun3 = new Urun();
            urun3.Urunadi = "Çizme";
            urun3.Urunfiyati = 420;
            urun3.Urunpuanı = 54;
            urun3.Urunrengi = "Siyah";

            Urun urun4 = new Urun();
            urun4.Urunadi = "Sweatshirt";
            urun4.Urunfiyati = 220;
            urun4.Urunpuanı = 64;
            urun4.Urunrengi = "Kahverengi";

            Urun urun5 = new Urun();
            urun5.Urunadi = "Mont";
            urun5.Urunfiyati = 500;
            urun5.Urunpuanı = 44;
            urun5.Urunrengi = "Kırmızı";


            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5 };

            foreach (var Urun in urunler)
            {
               Console.WriteLine(Urun.Urunadi+" : "+Urun.Urunfiyati+"TL: %"+Urun.Urunpuanı+" : "+Urun.Urunrengi);
            }
            Console.WriteLine("");
            Console.WriteLine("for için:");
            Console.WriteLine("");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Urunadi + " : " + urunler[i].Urunfiyati + "TL: %" + urunler[i].Urunpuanı+ " : " + urunler[i].Urunrengi);
            }

            Console.WriteLine("");
            Console.WriteLine("while için:");
            Console.WriteLine("");
            int a = 0;
            while (a<urunler.Length)
            {
                Console.WriteLine(urunler[a].Urunadi + " : " + urunler[a].Urunfiyati + "TL: %" + urunler[a].Urunpuanı + " : " + urunler[a].Urunrengi);
                a++;
            }
        }

        class Urun
        {
            public string Urunadi { get; set; }

            public string Urunrengi { get; set; }

            public int Urunfiyati { get; set; }

            public int Urunpuanı { get; set; }
        }
    }
}
