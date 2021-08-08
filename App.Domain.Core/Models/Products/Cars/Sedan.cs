using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Sedan : Car
    {
        public Sedan(string name, decimal price, string serial) : base(name, price, serial)
        {

        }
    }
}
