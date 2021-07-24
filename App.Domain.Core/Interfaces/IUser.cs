using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public interface IUser
    {
        Guid ID { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        DateTime RegistrationDate { get; set; }
    }
}
