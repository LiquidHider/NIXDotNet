using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Wheels : CarPart
    {
        public WheelDisk Disk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WheelTire Tire { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
