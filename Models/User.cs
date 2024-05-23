﻿using System.Numerics;
using System.Security.Cryptography;

namespace ImobSystem_API.Models
{
    public class User
    {
        #region Properties
        public uint id;
        public string name;
        public string email;
        public string password;
        public DateOnly age;
        public DateTime createdAt;
        public DateTime updatedAt;
        #endregion

        #region Constructor
        public User()
        {
            this.name = this.email = this.password = "";
            this.age = new DateOnly();
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
        }

        public User(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            //this.age = age;
            this.createdAt = DateTime.Now;
        }
        #endregion

        #region Get & Set of Properties
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public DateOnly getAge()
        {
            return this.age;
        }

        public void setAge(DateOnly age)
        {
            this.age = age;
        }
        #endregion

        #region Get the date and time when the user was created
        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }

        public void setCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
        }

        public DateTime GetUpdatedAt()
        {
            return this.updatedAt;
        }

        public void SetUpdatedAt(DateTime updatedAt)
        {
            this.updatedAt = updatedAt;
        }
        #endregion
    }
}
