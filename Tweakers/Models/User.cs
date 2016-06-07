using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using UserContext = Tweakers.Data.UserContext;
using System.ComponentModel.DataAnnotations;

namespace Tweakers.Models
{
    public class User
    {
        private UserContext ctx = new UserContext();
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

        public User LogIn(string name, string password)
        {
            return ctx.FindByLogin(name, password);
        }
    }
}