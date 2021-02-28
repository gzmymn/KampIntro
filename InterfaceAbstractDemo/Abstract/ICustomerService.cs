using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerService //interface implementasyonunu yapan herkes bu operasyonu kullanmak zorundadır
    {
        void Save(Customer customer);
    }
}
