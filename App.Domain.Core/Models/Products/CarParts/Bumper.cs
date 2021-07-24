using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Bumper : CarPart, ISolidMaterial, IColored
    {
        public LocationV Location;
        public SolidMaterial Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Color BodyColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ColorType ColorType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
