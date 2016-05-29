using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Model
{
    public class ShopPrice
    {
        public Shop Shop { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public string ProductURL { get; set; }

        public ShopPrice(Shop shop, Product product, double price, string productURL)
        {
            Shop = shop;
            Product = product;
            Price = price;
            ProductURL = productURL;
        }
    }
}