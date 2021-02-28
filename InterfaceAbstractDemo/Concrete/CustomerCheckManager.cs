using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(); //kötü kod--mernis'e bağımlı hale gelirsin, mernis çalışmazsa senin kodların da çalışmaz
            return true;
        }


    }
}
