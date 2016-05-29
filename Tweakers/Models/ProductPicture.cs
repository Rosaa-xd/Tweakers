using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class ProductPicture
    {
        public int ID { get; set; }
        public string PictureURL { get; set; }
        public Product Product { get; set; }

        public ProductPicture(int id, string pictureURL, Product product)
        {
            ID = id;
            PictureURL = pictureURL;
            Product = product;
        }

        public ProductPicture(string pictureURL, Product product)
        {
            PictureURL = pictureURL;
            Product = product;
        }
    }
}