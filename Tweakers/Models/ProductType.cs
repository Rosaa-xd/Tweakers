using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class ProductType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Product> Products;

        public ProductType(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public ProductType(string name)
        {
            Name = name;
        }

        public ProductType(string name, List<Product> products)
        {
            Name = name;
            Products = products;
        }
    }
}