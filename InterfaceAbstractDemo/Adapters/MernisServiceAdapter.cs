using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Adapters //Adapters -- Yani dış bir servisi sisteme adapte ederken 'Adapter' denilen design pattern kullanılır.
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
            //    customer.LastName.ToUpper(), customer.DateOfBirth.Year);

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year).Result;
            Console.WriteLine("TC Auth Services: " + result.Body.TCKimlikNoDogrulaResult);
            bool check = result.Body.TCKimlikNoDogrulaResult;
            return check;
        }
        
    }
}
