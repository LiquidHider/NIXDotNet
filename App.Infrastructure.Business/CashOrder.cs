using System;
using App.Services.Interfaces;
using App.Domain.Core;
namespace App.Infrastructure.Business
{
    public class CashOrder : IOrder<IProduct>
    {
        public void MakeOrder(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
