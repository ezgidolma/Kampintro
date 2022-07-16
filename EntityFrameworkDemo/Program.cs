using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {

   static void Main()
        {
            //GetAll();

             static void GetAll()
            {
                NorthwindContext context = new NorthwindContext();
                foreach (var product in context.Products)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

             static void GetProductsByCategory(int categoryId)
            {
                NorthwindContext context= new NorthwindContext();

                var result = context.Products.Where(p=>p.CategoryId==categoryId);

                foreach (var item in result)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            GetProductsByCategory(1);


        }

    }

}