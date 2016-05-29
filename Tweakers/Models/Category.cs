using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category ParentCategory { get; set; }
        public List<Product> Products;

        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Category(string name)
        {
            Name = name;
        }

        public Category(string name, Category category)
        {
            Name = name;
            ParentCategory = category;
        }

        public Category(string name, List<Product> products)
        {
            Name = name;
            Products = products;
        }

        public Category(string name, Category category, List<Product> products)
        {
            Name = name;
            ParentCategory = category;
            Products = products;
        }
    }
}