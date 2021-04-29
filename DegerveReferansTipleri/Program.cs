using System;

namespace DegerveReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yazılım Geliştirici Yetiştirme Kampı 3. Gün C# Temelleri 2 isimli videonun 2:10:00'dan sonrası anlatılıyor
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            //Soru: Sayi1'i yazdırsak kaç çıkar? (cevap en altta)

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //yazdırsak sıfırıncı eleman kaç çıkar? (cevap aşağıda)

            //NOT 1: int, decimal, flood, double, bool(çünkü arka planda 1 ve 0 tutar) değer tipli değişkenlerdir.

            //NOT 2: Array, class, interface ise referans tipli değişkenlerdir. Bunlar yukarıdaki örnekteki gibi int bile olsa referans tiplidir.













            //Cevaplar 30 ve 999. Cevapların değişik olmasının sebebi değer ve referans tiplerinde yani farklı mantıkla çalışmalarıdır. Bellekte stack ve heap diye iki alan vardır. Bir değişken tanımadığımızda değer tip olan işlemler stack içinde gerçekleşir. Referans tipli değişkenler ise heap'i aktif kullanırlar. Yani heap bellekte yeni bir adres oluşturur. Yani bu defa sayılar1'in referans numarası sayılar2'nin referans numarasına eşittir diye okumalıyız. DEĞER TİPLERDE DEĞERİ ATARIZ, REFERANS TİPLERDE REFERANS ATARIZ. Bu konu C gibi dillerde karşımıza POINTER olarak çıkar.


        }
    }
}
