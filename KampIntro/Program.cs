using System;

namespace KampIntro
{
    class Program
    {
        //type safety - tip güvenliği
        //Do not repeat yourself!!!
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler"; //değer tutucu, alias
            int ogrenciSayisi = 32000; //sınırlı bir sayıya kadar tutabiliyoruz
            double faizOrani = 1.45; //ondalıklı saylar
            bool sistemeGirisYapmisMi = true; //true ya da false döner
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            //Şart blokları
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

            if (sistemeGirisYapmisMi == true )
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
