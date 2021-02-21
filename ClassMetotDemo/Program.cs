using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Hatice";
            musteri1.Soyad = "Yaman";
            musteri1.Sehir = "Zonguldak";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ecrin";
            musteri2.Soyad = "Öztürk";
            musteri2.Sehir = "Bursa";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "İnci";
            musteri3.Soyad = "Öztürk";
            musteri3.Sehir = "Bursa";

            

            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("---Müşteri Listesi---");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.List(musteriler);

            musteriManager.Delete(musteri2);



            

        }
    }
}
