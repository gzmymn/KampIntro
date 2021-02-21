using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 10;
            int sayi3;
            int sayi4 = 15;

            Topla(ref sayi1, sayi2);
            
            Carp(out sayi3, sayi4);

        }
        public static void Topla(ref int sayi1, int sayi2)
        {
            sayi1 = 30;
            var sonuc1 = sayi1 + sayi2;
            
            Console.WriteLine("Toplam=" + sonuc1);
        }  
        
        public static void Carp(out int sayi3, int sayi4)
        {
            sayi3 = 20;
            var sonuc2 = sayi3 * sayi4;

            Console.WriteLine("Çarpım=" + sonuc2);
        }
    }
}
