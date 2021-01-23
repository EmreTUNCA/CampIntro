using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fıyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fıyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fıyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(".:*:.");
            }

            Console.WriteLine(".:--------------Metotlar----------------:.");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Devece Armutu", 12);
            sepetManager.Ekle2("elma", "Amasya Elması", 12);
            sepetManager.Ekle2("karpuz", "Diyarbakır Karpuzu", 12);
            sepetManager.Ekle2("çilek", "Dağ çileği", 12);
        }
    }
}

