using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Engine : CarPart
    {
        public EngineCylinderLocation CylinderLocation { get; set; }
        public EngineFuelSupplyType FuelSupplyType { get; set; }
    }
}
