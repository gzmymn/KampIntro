using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" }; //array ler oluşturulan sınırda takılır sadece, o sınırların dışına onu çıkaramazsın
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //bu şekilde de yeni bir array oluşturur ve ilk 4 elemanı boş 5.eleman ilker olur ve bunu yazdırır.
            //isimler[4] = "İlker"; 
            //Console.WriteLine(isimler[4]); //bu şekilde bize uyarı verecektir çünkü array sınırlarını aştık 
            //Console.WriteLine(isimler[0]);


            //C#, java gibi programlarda genellile array kullanılmıyor. Onun yerine ;
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; //string array i değil de string listesi
            Console.WriteLine(isimler2[0]); //koleksiyonlarda değerleri kaybetmemizi engelleyecek bir alt yapı var.
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
