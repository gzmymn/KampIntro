using System;

namespace Constructors
{
    class Program
    {
        //constructor bir class'ı new'lediğimiz zaman çalışan bloktur
        //Bir class ilk kez oluştuğu zaman bir kere çalışır ve bir daha çalışmaz dediğimiz bloktur.
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Gizem", LastName="Yaman", City="Zonguldak" };

            Customer customer3 = new Customer(); //yukarıdaki ve bu kullanım aynıdır.
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Alparslan", "Tekkanat", "Antalya");

            Console.WriteLine(customer2.FirstName);

        }        
    }


    class Customer
    {
        //Contructor yazmak için ctor tab tab yapıyoruz -- Constructor da bir method gibi çalışır
        //default constructor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)  //bu şekilde yukarıdaki Customer'ların ikisi de kızmadı
        {
            Id = id;
            FirstName = firstName;  //Console.WriteLine'da customer2.FirstName tarzında çağırdığımızda ekrana gelmesi için bunları yapmamız gerekir
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
