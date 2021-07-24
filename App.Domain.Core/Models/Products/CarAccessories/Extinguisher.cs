using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Extinguisher : CarAccessory, IColored
    {
        public Color BodyColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
