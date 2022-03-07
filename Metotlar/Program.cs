using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi="Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+" "+urun.Aciklama+" "+urun.Fiyati);
                Console.WriteLine("----------------");
            }


            Console.WriteLine("------------------------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut", "Yeşil", 12,3);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,4);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,5);





        }
        
    }
}
