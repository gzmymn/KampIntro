using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı -  kodun okunurluğu için doğru yazma tekniklerini kullanıyoruz
        public void Ekle(Urun urun) //bir yerde () görürsek orada bir metot çalıştığını anlayacağız
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // böyle de yazabiliriz ama yazmamalıyız. çünkü bu metoda bir ekleme yaptığımızda tüm sayfalarda değişiklik yapmamız gerekecek
            //Ama class ile bunu yaparsak öyle bir sorun yaşamayacağız
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
