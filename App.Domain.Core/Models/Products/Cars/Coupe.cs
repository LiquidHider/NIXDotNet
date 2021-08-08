using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Coupe : Car
    {
        public Coupe(string name, decimal price, string serial) : base(name, price, serial)
        {

        }
    }
}
