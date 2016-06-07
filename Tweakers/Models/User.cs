﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Oracle.ManagedDataAccess.Client;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data;

namespace Tweakers.Models
{
    public class User : DbContext
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public List<UserList> UserLists;
        public List<Review> Reviews;

        public User(int id, string name, string password)
        {
            ID = id;
            Name = name;
            Password = password;
        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public User(string name, string password, List<UserList> userLists, List<Review> reviews)
        {
            Name = name;
            Password = password;
            UserLists = userLists;
            Reviews = reviews;
        }

        public User()
        {
            
        }

        public static User FindByLogin(string name, string password)
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

        private static User GetUserFromDataRecord(IDataRecord record)
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