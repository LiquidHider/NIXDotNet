using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Dealer : IHaveContactInfo
    {
        public Guid ID { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get; set; }

    }
}
