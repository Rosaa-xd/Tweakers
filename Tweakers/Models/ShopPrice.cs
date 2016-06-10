using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace Tweakers.Models
{
    public class ShopPrice : DbContext
    {
        public Shop Shop { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public string ProductURL { get; set; }

        #region Constructors
        public ShopPrice(Shop shop, Product product, double price, string productURL)
        {
            Shop = shop;
            Product = product;
            Price = price;
            ProductURL = productURL;
        }

        public ShopPrice(Shop shop, double price, string productURL)
        {
            Shop = shop;
            Price = price;
            ProductURL = productURL;
        }
        #endregion

        #region DatabaseMethods

        public static List<ShopPrice> AllShopPriceOfProduct(int id)
        {
            List<ShopPrice> shopPrices = new List<ShopPrice>();

            string query = "SELECT * " +
                           "FROM TBL_SHOP_PRODUCT " +
                           "WHERE PRODUCT_ID=:id";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("id", id));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            shopPrices.Add(GetShopPriceDataFromRecord(reader));
                        }
                    }
                }
            }
            return shopPrices;
        }

        private static ShopPrice GetShopPriceDataFromRecord(IDataRecord record)
        {
            return new ShopPrice(
                Shop.FindById(Convert.ToInt32(record["SHOP_ID"])),
                Convert.ToDouble(record["PRICE"]),
                Convert.ToString(record["WEBLINK"]));
        }
        #endregion
    }
}