using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    class Moderator : IUser, ICanEditProducts
    {
        public Guid ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime RegistrationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
