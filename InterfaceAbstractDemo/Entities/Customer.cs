using InterfaceAndAbstractDemo.Abstract;
using System;

namespace InterfaceAndAbstractDemo.Entities
{
    public class Customer:IEntity //IEntity'yi customer'ın bir veritabanı nesnesi olduğunu göstermek için söyleriz
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }

    
}
