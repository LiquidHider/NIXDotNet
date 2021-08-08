using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Moderator : User, ICanEditProducts
    {
        public Moderator(string login, string password) : base(login, password)
        {

        }
        public void AddProduct(IProduct item)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(IProduct item)
        {
            throw new NotImplementedException();
        }

        public void MakeDiscount(IProduct item, int discountPercent)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(IProduct item)
        {
            throw new NotImplementedException();
        }
    }
}
