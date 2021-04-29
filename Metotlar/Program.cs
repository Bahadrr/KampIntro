namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";

            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                System.Console.WriteLine(urun.Adi);
                System.Console.WriteLine(urun.Fiyati);
                System.Console.WriteLine(urun.Aciklama);
                System.Console.WriteLine("-----------------");
            }

            System.Console.WriteLine("----Metotlar-----");
            //Instance - Örnek
            //Encapsulation

            SepetManager SepetManager = new SepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);

            SepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            SepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            SepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}


//Don't repeat yourself (DRY) / kendini tekrar etme 
//Clean code
//Best Practice (Doğru Uygulama teknikleri/En iyi uygulama teknikleri)