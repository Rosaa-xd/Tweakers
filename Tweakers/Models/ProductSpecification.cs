using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace Tweakers.Models
{
    public class ProductSpecification : DbContext
    {
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        #region Constructors
        public ProductSpecification(Product product, string name, string value)
        {
            Product = product;
            Name = name;
            Value = value;
        }

        public ProductSpecification(string name, string value)
        {
            Name = name;
            Value = value;
        }
        #endregion

        #region DatabaseMethods

        public static List<ProductSpecification> FindAllSpecs(int id)
        {
            List<ProductSpecification> productSpecifications = new List<ProductSpecification>();

            string query = "SELECT PS.SPEC_VALUE, S.NAME " +
                           "FROM TBL_SPECIFICATION S " +
                           "INNER JOIN TBL_PRODUCT_SPEC PS ON PS.SPEC_ID = S.ID " +
                           "INNER JOIN TBL_PRODUCT P ON PS.PRODUCT_ID = P.ID " +
                           "WHERE P.ID=:id";

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
                            productSpecifications.Add(GetSpecFromDataRecord(reader));
                        }
                    }
                }
            }
            return productSpecifications;
        }

        private static ProductSpecification GetSpecFromDataRecord(IDataRecord record)
        {
            return new ProductSpecification(
                Convert.ToString(record["NAME"]),
                Convert.ToString(record["SPEC_VALUE"]));
        }
        #endregion
    }
}