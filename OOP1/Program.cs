using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Productname = "Masa";
            product1.Unitprice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { CategoryId = 5, Id = 2, Productname = "Kalem", Unitprice = 35, UnitsInStock = 2 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

           
           
            

        }
    }
}
