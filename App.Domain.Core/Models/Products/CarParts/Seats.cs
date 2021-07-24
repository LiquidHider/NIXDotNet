using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Seats : CarPart
    {
        public bool IsHeated { get; set; }
        public SoftMaterial CoverMaterial { get; set; }
    }
}
