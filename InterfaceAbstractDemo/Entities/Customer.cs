 using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
   
        public class Customer:IEntity
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public DateTime DateofBirth { get; set; }
            public string NationalityId { get; set; }

        }
    
}
