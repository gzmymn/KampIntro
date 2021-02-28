using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;
using System;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth= new DateTime(1994,9,29), FirstName="Gizem Kübra", LastName="Yaman", NationalityId=66655281010 }) ;
            Console.ReadLine();
        }
    }
}
