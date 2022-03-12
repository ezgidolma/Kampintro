using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 211;
            musteri1.Ad = "Ezgi";
            musteri1.Soyad = "Dolma";
           

            Musteri musteri2 = new Musteri();
            musteri2.Id = 212;
            musteri2.Ad = "Kübra";
            musteri2.Soyad = "Çelik";
            

            Musteri musteri3 = new Musteri();
            musteri3.Id = 213;
            musteri3.Ad = "Esen";
            musteri3.Soyad = "Hançerli";
        

            Musteri musteri4 = new Musteri();
            musteri4.Id = 212;
            musteri4.Ad = "Fatma";
            musteri4.Soyad = "Kaya";
            


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            Console.WriteLine();

            musteriManager.Listeleme(musteriler);
            Console.WriteLine();
            musteriManager.Silme(musteri4);
            Console.WriteLine();
            musteriManager.Listeleme(musteriler);



        }
    }
}
