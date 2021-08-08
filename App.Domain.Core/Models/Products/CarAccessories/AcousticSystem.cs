using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class AcousticSystem : IPartnerProduct
    {
        public Partner Manufacturer { get; set; } 
        public AcousticSystemType Type { get; set; }
    }
}
