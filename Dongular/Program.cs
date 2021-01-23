using System;

namespace Dongular
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılımcı Yetiştirme Kampı";
            //string kurs2 = "Proglamlamaya Başlangıç İçin Temel Kurs";
            //string kurs3 = "Java";

            string[] kurslar = new string[]
            {
                "Yazılımcı Yetiştirme Kampı",
                "Proglamlamaya Başlangıç İçin Temel Kurs" ,
                "Java",
                "Veri Bilimi",
                "C#"
            };



            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("For bitti");

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
