using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming Convention
        //syntax
        //Bir class içinde birden çok metot olabilir.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stopAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
