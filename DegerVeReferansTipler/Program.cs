using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Firstname = "Engin";

            person2 = person1;
            person1.Firstname = "Kübra";

            Console.WriteLine(person2.Firstname);

            Customer customer = new Customer();
            customer.Firstname = "Salih";
            customer.CreditNumber = 12233;

            Employee employee = new Employee();

            Person person3 = customer;
            customer.Firstname = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);

        }
        class Person
        {
            public int Id { get; set; }

            public string Firstname { get; set; }

            public string Lastname { get; set; }
        }

        class Customer : Person
        {
            public int CreditNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.Firstname);
            }
        }
    }
}
