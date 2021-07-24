using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class BabySeat : CarAccessory, ISoftMaterial
    {
        public SoftMaterial Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
