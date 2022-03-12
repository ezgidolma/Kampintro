using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+":"+musteri.Id+" müsterisi başarıyla eklendi");
        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad +" "+ musteri.Soyad +":"+ musteri.Id );
            }
          
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +" "+ musteri.Soyad +":"+ musteri.Id + " müsterisi başarıyla silindi");
        }

    }
}
