using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Model
{
    public class Asset
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Explanation { get; set; }
        public List<ProductReview> ProductReviews;

        public Asset(int id, string type, string explanation)
        {
            ID = id;
            Type = type;
            Explanation = explanation;
        }

        public Asset(string type, string explanation)
        {
            Type = type;
            Explanation = explanation;
        }

        public Asset(string type, string explanation, List<ProductReview> productReviews)
        {
            Type = type;
            Explanation = explanation;
            ProductReviews = productReviews;
        }
    }
}