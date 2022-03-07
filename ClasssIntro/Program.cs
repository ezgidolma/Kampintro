using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitimadi = "C#";
            kurs1.Egitmenadi = "Engin Demiroğ";
            kurs1.Tamamlamaoranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Egitimadi = "Java";
            kurs2.Egitmenadi = "Kerem Demiroğ";
            kurs2.Tamamlamaoranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Egitimadi = "Python";
            kurs3.Egitmenadi = "Ezgi Demiroğ";
            kurs3.Tamamlamaoranı = 98;

            //Console.WriteLine(kurs1.Egitimadi + " : " + kurs1.Egitmenadi);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurss in kurslar)
            {
                Console.WriteLine(kurss.Egitimadi+ " : " +kurss.Egitmenadi);
            }
        }

        class Kurs
        {
            public string Egitimadi { get; set; }

            public string Egitmenadi { get; set; }

            public int Tamamlamaoranı { get; set; }
        }
    }
}
