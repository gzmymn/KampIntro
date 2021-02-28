using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService //Böyle yapmamızın sebebi her iki firmanın da aynı şekilde kullanacağı operasyon kodlarını yazabilmek
                                                        //Çünkü ICustomerService içerisinde içi dolu metot yazamıyorum 
                                                        //Ama burada metotların içini doldurup her iki firmada da kullanabileceğiz.
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName); //Bu ortak operasyon, yani iki firma da bu metodu aynen kullanacak
        }
    }
}
