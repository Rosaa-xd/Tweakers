using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ShopPrice> ShopPrices;

        public Shop(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Shop(string name)
        {
            Name = name;
        }

        public Shop(string name, List<ShopPrice> shopPrices)
        {
            Name = name;
            ShopPrices = shopPrices;
        }
    }
}