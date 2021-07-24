using System;

namespace App.Domain.Core
{
    public interface IProduct
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DiscountPercent { get; set; }
        public string SerialNumber { get; set; }
    }
}
