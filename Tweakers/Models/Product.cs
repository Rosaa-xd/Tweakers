using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Tweakers.Models
{
    public class Product : DbContext
    {
        private static List<Product> products = new List<Product>();

        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string SKU { get; set; }
        public int EAN { get; set; }
        public ProductType ProductType { get; set; }
        public Category Category { get; set; }
        public List<ProductPicture> ProductPictures;
        public List<ProductSpecification> ProductSpecifications;
        public List<UserList> UserLists;
        public List<Review> Reviews;
        public List<ShopPrice> ShopPrices;

        #region Constructors
        public Product(int id, string name, string brand, string sku, int ean)
        {
            ID = id;
            Name = name;
            Brand = brand;
            SKU = sku;
            EAN = ean;
        }

        public Product(string name, string brand, string sku, int ean)
        {
            Name = name;
            Brand = brand;
            SKU = sku;
            EAN = ean;
        }

        public Product(int id, string name, string brand, string sku, int ean, ProductType productType, Category category)
        {
            ID = id;
            Name = name;
            Brand = brand;
            SKU = sku;
            EAN = ean;
            ProductType = productType;
            Category = category;
        }

        public Product(string name, string brand, string sku, int ean, ProductType productType, Category category)
        {
            Name = name;
            Brand = brand;
            SKU = sku;
            EAN = ean;
            ProductType = productType;
            Category = category;
        }

        public Product(string name, string brand, string sku, int ean, ProductType productType, Category category,
            List<ProductPicture> productPictures, List<ProductSpecification> productSpecifications,
            List<UserList> userLists, List<Review> reviews, List<ShopPrice> shopPrices)
        {
            Name = name;
            Brand = brand;
            SKU = sku;
            EAN = ean;
            ProductType = productType;
            Category = category;
            ProductPictures = productPictures;
            ProductSpecifications = productSpecifications;
            UserLists = userLists;
            Reviews = reviews;
            ShopPrices = shopPrices;
        }
        #endregion

        #region DatabaseMethods

        public static List<Product> FindAllProductsInCategory(int category_id)
        {
            string query = "SELECT * " +
                           "FROM TBL_PRODUCT " +
                           "WHERE CATEGORY_ID:=category_id";


            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("category_id", category_id));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    products.Add(GetProductFromDataRecord(reader));
                }
            }
            return products;
        }

        private static Product GetProductFromDataRecord(IDataRecord record)
        {
            return new Product(
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["NAME"]),
                Convert.ToString(record["BRAND"]),
                Convert.ToString(record["SKU"]),
                Convert.ToInt32(record["EAN"]),
                ProductType.FindById(Convert.ToInt32(record["PRODUCTTYPE_ID"])),
                Category.FindById(Convert.ToInt32(record["CATEGORY_ID"])));
        }

        #endregion
    }
}