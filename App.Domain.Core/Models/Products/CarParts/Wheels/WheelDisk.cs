using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class WheelDisk : CarPart, ISolidMaterial
    {
        public WheelDiskType Type { get; set; }
        public SolidMaterial Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
