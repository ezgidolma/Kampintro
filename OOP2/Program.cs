using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.MusteriNo = "123455";
            musteri1.TcNo = "1234567890";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "282882";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123445";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri1);






        }
    }
}
