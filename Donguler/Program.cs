using System;

namespace Donguler
{
    class Program
    {
        //Döngüleri birbirine benzeyen işlemleri tekrar etmek için kullanırız
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";
            //bu tip verilerimizi array=dizilerde tutarız

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java", "Python", "C++" };
            

            for (int i = 0; i < kurslar.Length; i++) //kurslar.Length = kursların eleman saysı kadar dönecek demektir. Ekranı dinamikleştirmiş oluyoruz
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarıyor, for'dan daha kullanışlı
            {
                Console.WriteLine(kurs); //kurs = alias
            }
            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
