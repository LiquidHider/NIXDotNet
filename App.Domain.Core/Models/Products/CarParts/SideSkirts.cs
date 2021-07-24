using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class SideSkirts : CarPart, ISolidMaterial, IColored
    {
        public Color BodyColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public SolidMaterial Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
