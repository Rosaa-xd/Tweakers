using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class ProductSpecification
    {
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public ProductSpecification(Product product, string name, string value)
        {
            Product = product;
            Name = name;
            Value = value;
        }
    }
}