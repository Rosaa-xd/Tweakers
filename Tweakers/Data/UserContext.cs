using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Tweakers.Models;

namespace Tweakers.Data
{
    public class UserContext : DbContext
    {
        public User FindByLogin(string name, string password)
        {
            string query = "SELECT * " +
                           "FROM TBL_USER " +
                           "WHERE USERNAME=:name " +
                           "AND PASSWORD=:password";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("name", name));
                command.Parameters.Add(new OracleParameter("password", password));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return GetUserFromDataRecord(reader);
                }
            }
            return null;
        }

        private User GetUserFromDataRecord(IDataRecord record)
        {
            return new User
            (
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["USERNAME"]),
                Convert.ToString(record["PASSWORD"])
            );
        }
    }
}