using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Transmission : CarPart
    {
        public bool IsAutomatic { get; set; }
        public TransmissionType Type { get; set; }
    }
}
