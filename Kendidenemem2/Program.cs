using System;

namespace Kendidenemem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kayıt adınızı giriniz");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Kayıt şifrenizi giriniz");
            int kullaniciSifresi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kayıt gerçekleşti. Lütfen siteye giriş yapınız.");
            Console.WriteLine("Kullanıcı adınızı giriniz:");
            string girilenAd = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            int girilenSifre = Convert.ToInt32(Console.ReadLine());
            
            if (kullaniciAdi == girilenAd && girilenSifre == kullaniciSifresi) 
            {
                Console.WriteLine("Giriş başarılı");
            }

            else
            {
                Console.WriteLine("Giriş başarısız.");
            }
        }
    }
}
