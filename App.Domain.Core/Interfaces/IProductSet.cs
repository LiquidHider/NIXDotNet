using System.Collections.Generic;

namespace App.Domain.Core
{
    public interface IProductSet<T> where T : IProduct
    {
         List<T> products { get; set; }
         decimal SummaryPrice { get; set; }
         decimal GetSummaryPrice();
         List<T> GetAll();
    }
}
