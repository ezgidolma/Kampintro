using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager//Ürünle ilgili operasyonlar içerir Ekleme silme vb.

    {
        public void Add(Product product)
         {
            Console.WriteLine(product.Productname + " eklendi.");
         }

        public void Update(Product product)
        {
            Console.WriteLine(product.Productname + " güncellendi.");
        }

        
    }
}
