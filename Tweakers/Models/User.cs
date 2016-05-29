using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
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
    }
}