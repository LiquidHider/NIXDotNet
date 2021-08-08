using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace App.Domain.Core
{
    [Serializable]
    public class Customer : User
    {
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
       
        public Customer(string login, string password, string email = "None", string lastName = "None", string firstName = "None", string phoneNumber = "None") : base(login, password)
        {
            Email = email;
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
        }
        private Customer()
        {

        }
    }
}
