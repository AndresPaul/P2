﻿using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager : IUserManager
    {
        public List<User> Users {get;set;}
        public UserManager()
        {
            Users = new List<User>()
            {
                //new User() { Name = "Paul" },
                //new User() { Name = "Andres" },
                new User(){ Id = 1, Name = "Andres", Surname = "Mont", Email = "",},
                new User() { Id = 2, Name = "Paul", Surname = "Cesp", Email = "", },
            };
        }
        public List<User> GetUsers()
        {
            return Users;
        }
        
        public User PostUser(User user)
        {
            Users.Add(user);
            return user;
        }
        public User PutUser(User user)
        {
            var userToUpdate = Users.Find(u => u.Id == user.Id);
            userToUpdate.Name = user.Name;
            userToUpdate.Surname = user.Surname;
            userToUpdate.Email = user.Email;
            return userToUpdate;
        }
    

    }
}
