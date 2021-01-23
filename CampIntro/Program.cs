using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.5;
            double dolarBugun = 7.6;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu.");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Stabil");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu.");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu.");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
