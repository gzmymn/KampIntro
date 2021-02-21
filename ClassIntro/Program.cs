using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs(); //benim artık bir Kurs tipinde kurs1'im var
            kurs1.KursAdi = "C#";       //değişkenlerini oluşturmak ve atama yapmak için bu yolları izliyoruz.
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); 
            kurs2.KursAdi = "Java";       
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); 
            kurs3.KursAdi = "Python";       
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();        //yeni bir kurs eklediğimizde bize kolaylık sağlıyor aşağıdaki format
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 }; //bu yapıda önceki uygulamada string tutuyorduk şimdi Kurs tutuyoruz.

            foreach (var kurs in kurslar) //kurs=takma isim
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs //class ile kendi değişkenini yazıyormuş-oluşturuyormuş gibi düşün
    {
        //prop=property=özellik 
        public string KursAdi { get; set; } //prop tab tab
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
