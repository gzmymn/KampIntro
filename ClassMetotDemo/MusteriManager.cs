using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri eklendi:" + " " +  musteri.Ad + " " + musteri.Soyad);
        }

        public void List(Musteri[] musteri)
        {
            foreach (var m in musteri)
            {
                Console.WriteLine("Id:" + m.Id);
                Console.WriteLine("Ad:" + m.Ad);
                Console.WriteLine("Soyad:" + m.Soyad);
                Console.WriteLine("Sehir:" + m.Sehir);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine("Müşteriler Listelendi.");
        }

        

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi:" + musteri.Ad + musteri.Soyad);
        }
                
    }
}
