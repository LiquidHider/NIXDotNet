using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public abstract class CarAccessory : IProduct, ICarModule
    {
        public Guid ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DiscountPercent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] CarTypeCompabilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
