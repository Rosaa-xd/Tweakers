using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class ProductSpecification
    {
        public Specification Specification { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }

        public ProductSpecification(Specification specification, Product product, string value)
        {
            Specification = specification;
            Product = product;
            Value = value;
        }
    }
}