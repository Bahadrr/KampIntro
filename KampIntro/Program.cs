using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //kategori etiketi bir değer tutucudur, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            //if (SistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanıcı ayarlar butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giris yap butonu")
            //}

            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
        }
    }
}
