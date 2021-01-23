using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Emre";
            string soyad = "TUNCA";
            int yas = 27;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 25.5;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Berkay";
            kurs2.IzlenmeOrani = 23.5;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kerem";
            kurs3.IzlenmeOrani = 24.5;

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "/"+ kurs.Egitmen);
            }

        }
    }

    class kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public double IzlenmeOrani { get; set; }
    }
}
