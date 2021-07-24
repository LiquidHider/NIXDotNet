using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Spoiler : CarAccessory, ISolidMaterial, IColored
    {
        public SolidMaterial Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Color BodyColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
