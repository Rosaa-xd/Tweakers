using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Model
{
    public class Specification
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ProductSpecification> ProductSpecifications;

        public Specification(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Specification(string name)
        {
            Name = name;
        }

        public Specification(string name, List<ProductSpecification> productSpecifications)
        {
            Name = name;
            ProductSpecifications = productSpecifications;
        }
    }
}