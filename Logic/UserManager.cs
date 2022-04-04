using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager
    {
        public List<User> Users{get;set;}
        public List<User> GetUsers()
        {

            return new List<User>
            {
                 new User { Id = 1, Name = "Juan", Surname = "Doe", Email = "" }
            };
        }
        public User PostUsers(User user)
        {
            Users.Add(user);
            return user;
        }

        /*public User PutUsers(User user)
        {
            return new User { Id = 1, Name = "Juan", Surname = "Doe", Email = "" }
        }*/

    }
}
