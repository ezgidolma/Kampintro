using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
         
            customerManager.Save(new Entities.Customer
            {
                Id = 1,
                DateofBirth = new DateTime(2001, 11, 12),
                Firstname = "Engin",
                Lastname = "Demiroğ",
                NationalityId = "1192838383839"
            });
            Console.ReadLine();
        }
    }
}
