using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public abstract class User
    {
        public Guid ID { get;  protected set; }
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public DateTime RegistrationDate { get; protected set; }
        protected User() { }
        protected User(string login, string password) 
        {
            ID = Guid.NewGuid();
            Login = login;
            Password = password;
            RegistrationDate = DateTime.Now;
        }
    }
}
