using System;
using System.Collections.Generic;

namespace App.Domain.Core
{
    public abstract class Car : IProduct, IColored
    {
        public Guid ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DiscountPercent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ReleaseYear { get; set; }
        public Color BodyColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int BodyLength { get; set; }
        public int BodyWidth { get; set; }
        public int BodyHeight { get; set; }
        public int SeatsCount { get; set; }
        public int DoorsCount { get; set; }
        public Seats Seats { get; set; }
        public Bumper FrontBumper { get; set; }
        public Bumper BackBumper { get; set; }
        public RearViewMirrors RearViewMirrors { get; set; }
        public Wheels Wheels { get; set; }
        public SideSkirts SideSkirts { get; set; }
        public Transmission Transmission { get; set; }
        public BreakSystem BreakSystem { get; set; }
        public Engine Engine { get; set; }
        public Headlights Headlights { get; set; }
        public WindowsSet Windows { get; set; }
        public List<CarAccessory> Accessories { get; set; }
    }
}
