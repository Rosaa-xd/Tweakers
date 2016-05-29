using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class UserList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public User User { get; set; }
        public List<Product> Products;

        public UserList(int id, string name, string type)
        {
            ID = id;
            Name = name;
            Type = type;
        }

        public UserList(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public UserList(string name, string type, User user)
        {
            Name = name;
            Type = type;
            User = user;
        }

        public UserList(string name, string type, User user, List<Product> products)
        {
            Name = name;
            Type = type;
            User = user;
            Products = products;
        }
    }
}