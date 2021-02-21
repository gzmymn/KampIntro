using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Kategori = "Ev";
            urun1.UrunAdi = "Masa";
            urun1.Fiyat = 199.99;
            urun1.StokAdedi = 10;

            Product urun2 = new Product();
            urun2.Kategori = "Ev";
            urun2.UrunAdi = "Avize";
            urun2.Fiyat = 99.99;
            urun2.StokAdedi = 5;

            Product urun3 = new Product();
            urun3.Kategori = "Kıyafet";
            urun3.UrunAdi = "Elbise";
            urun3.Fiyat = 69.99;
            urun3.StokAdedi = 20;

            Product urun4 = new Product();
            urun4.Kategori = "Ayakkabı";
            urun4.UrunAdi = "Bot";
            urun4.Fiyat = 265.95;
            urun4.StokAdedi = 3;

            Product urun5 = new Product();
            urun5.Kategori = "Kırtasiye";
            urun5.UrunAdi = "Kalem";
            urun5.Fiyat = 20;
            urun5.StokAdedi = 10;

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4, urun5 };

            Console.WriteLine("FOR DÖNGÜSÜ");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Kategori:" + urunler[i].Kategori + "\n" + "Ürün Adı:" + urunler[i].UrunAdi + "\n" + "Ürün Fiyatı:" + urunler[i].Fiyat + "\n" + "Stoktaki Ürün:" + urunler[i].StokAdedi);
                Console.WriteLine("..................");
            }

            Console.WriteLine("FOREACH DÖNGÜSÜ");
            foreach (var urun in urunler) 
            {
                Console.WriteLine("Kategori:" + urun.Kategori+ "\n"  + "Ürün Adı:" + urun.UrunAdi + "\n"  + "Ürün Fiyatı:" + urun.Fiyat + "\n"  + "Stoktaki Ürün:" + urun.StokAdedi);
                Console.WriteLine("..................");
            }

            Console.WriteLine("WHILE DÖNGÜSÜ");
            int j = 0;
            while (j<=urunler.Length)
            {
                Console.WriteLine("Kategori:" + urunler[j].Kategori + "\n" + "Ürün Adı:" + urunler[j].UrunAdi + "\n" + "Ürün Fiyatı:" + urunler[j].Fiyat + "\n" + "Stoktaki Ürün:" + urunler[j].StokAdedi);
                Console.WriteLine("..................");
                j++;
            }
        }
    }
    class Product
    {
        public string Kategori { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public int StokAdedi { get; set; }

    }
}
