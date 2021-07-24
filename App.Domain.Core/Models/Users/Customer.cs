using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Customer : IUser
    {
        public Guid ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime RegistrationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
