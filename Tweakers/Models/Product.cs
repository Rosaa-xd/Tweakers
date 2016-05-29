using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class Product
    {
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
    }
}