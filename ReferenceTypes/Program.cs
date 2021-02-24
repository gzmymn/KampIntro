using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Value Types -- int, decimal, enum, boolean
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 30;
            //Console.WriteLine("Sayı1 = " + sayi1); //20

            ////Reference Types -- arrays, class, interface
            //int[] sayi3 = new int[] {4, 5, 6};
            //int[] sayi4 = new int[] {100, 200, 300};
            //sayi3 = sayi4;
            //sayi4[0] = 1500;

            //Console.WriteLine("Sayi4[0] = " + sayi4[0]); //1500

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Gizem";
            
            person2 = person1;
            person1.FirstName = "Alparslan";

            Console.WriteLine(person2.FirstName); //Class'lar referans tip olduğu için Alparslan yazdırır.


            Customer customer = new Customer();
            customer.FirstName = "Ali";
            customer.CreditCardNumber = "1234667";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //customer=employee //bunu yapamayız çünkü ikisi farklı tipler. biri string biri int gibi düşün..

            Person person3 = customer;//burada hata vermez çünkü customer'ı person olarak implemente ettik..
            customer.FirstName = "Ahmet"; //person3 customer'ın adresini tutuyor
            Console.WriteLine(person3.FirstName);//önce ali sonra ahmet yazdırır. 

            Console.WriteLine(((Customer)person3).CreditCardNumber); //person3'e Customer BOXING'i yaptık

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee); //Üçünü de kabul ediyor çünkü person hepsini kapsıyor.


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //Base Class = Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) //Buraya Person atadığımızda aslında hem customer hem de employee atamış oluyoruz.
                                       //Bunun için inheritance kullandık.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
