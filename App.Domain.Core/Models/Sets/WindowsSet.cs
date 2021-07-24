using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public struct WindowsSet : IProductSet<IProduct>
    {
       // public IProduct GetWindow()
        public List<IProduct> products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal SummaryPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IProduct GetWindow(LocationH h) => throw new NotImplementedException();
        public IProduct GetWindow(LocationV v) => throw new NotImplementedException();
        public List<IProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public decimal GetSummaryPrice()
        {
            throw new NotImplementedException();
        }
    }
}
