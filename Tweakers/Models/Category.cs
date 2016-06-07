using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace Tweakers.Models
{
    public class Category : DbContext
    {
        private static List<Category> categories = new List<Category>();
        private static List<Category> parentCategories = new List<Category>();
        public int ID { get; set; }
        public string Name { get; set; }
        public Category ParentCategory { get; set; }
        public List<Product> Products;

        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Category(int id, string name, Category category)
        {
            ID = id;
            Name = name;
            ParentCategory = category;
        }

        public Category(string name, List<Product> products)
        {
            Name = name;
            Products = products;
        }

        public Category(int id, string name, Category category, List<Product> products)
        {
            ID = id;
            Name = name;
            ParentCategory = category;
            Products = products;
        }

        public static List<Category> ReturnAllCategories()
        {
            string query = "SELECT * " +
                           "FROM TBL_CATEGORY";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                     categories.Add(GetCategoryFromDataRecord(reader));
                }
            }
            return categories;
        }

        public static List<Category> ReturnAllParentCategories()
        {
            string query = "SELECT * " +
                           "FROM TBL_CATEGORY " +
                           "WHERE CATGORY_ID IS NULL";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    parentCategories.Add(GetCategoryFromDataRecord(reader));
                }
            }
            return parentCategories;
        }

        public static Category FindById(int id)
        {
            string query = "SELECT * FROM TBL_CATEGORY WHERE ID=:id";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("id", id));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return GetCategoryFromDataRecord(reader);
                    }
                }
            }
            return null;
        }

        private static Category GetCategoryFromDataRecord(IDataRecord record)
        {
            if (!Convert.IsDBNull(record["CATEGORY_ID"]))
            {
                return new Category(
                    Convert.ToInt32(record["ID"]),
                    Convert.ToString(record["NAME"]),
                    FindById(Convert.ToInt32(record["CATEGORY_ID"])));
            }
            return new Category(
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["NAME"]));
        }
    }
}