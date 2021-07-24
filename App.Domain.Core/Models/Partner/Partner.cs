using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Partner : IHaveContactInfo
    {
        public Guid Id { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PartnerSpecialization Specialization { get; set; }
        public string ContactNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
