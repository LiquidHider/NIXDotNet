using System;
using System.Collections.Generic;

namespace App.Domain.Core
{
    public abstract class Car : IProduct, IColored
    {
        public Guid ID { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public int DiscountPercent { get; protected set; }
        public string SerialNumber { get; protected set; }
        public int ReleaseYear { get; set; }
        public Color BodyColor { get; protected set; }
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
        public Car(string name,decimal price, string serial) 
        {
            ID = Guid.NewGuid();
            Name = name;
            Price = price;
            SerialNumber = serial;
        }
    }
}
