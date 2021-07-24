using System;
using System.Collections.Generic;
using System.Text;
using App.Services.Interfaces;
using App.Domain.Core;

namespace App.Infrastructure.Business
{
    class CreditOrder : IOrder<IProduct>
    {
        public void MakeOrder(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
