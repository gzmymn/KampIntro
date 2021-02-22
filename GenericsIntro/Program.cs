using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //MyList generik tipinde bir class olduğu için <> ile ne olduğunu belirtmemiz gerekiyor
            isimler.Add("Engin");                          //yani burda T'ye string demiş oluyoruz
            Console.WriteLine("Hello World!");
        }
    }
}
