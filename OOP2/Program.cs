using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Emre";
            musteri1.Soyadi = "TUNCA";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "456789";
            musteri2.SirketAdi = "EmreTUNCAMühendislik";
            musteri2.VergiNo = "123456";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


        }
    }
}
