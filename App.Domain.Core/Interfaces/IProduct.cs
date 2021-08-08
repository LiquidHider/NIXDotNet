using System;

namespace App.Domain.Core
{
    public interface IProduct
    {
        public Guid ID { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int DiscountPercent { get; }
        public string SerialNumber { get; }
    }
}
