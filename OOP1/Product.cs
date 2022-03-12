using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product // Entity
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Productname { get; set; }

        public double Unitprice { get; set; } //Ürünün birim fiyatı

        public int UnitsInStock { get; set; }//Stok adedi




    }
}
