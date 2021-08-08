using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public class Administrator : User, ICanEditProducts
    {
        public void AddProduct(IProduct item) => throw new NotImplementedException();
        public void RemoveProduct(IProduct item) => throw new NotImplementedException();
        public void AddAdministrator(User user) => throw new NotImplementedException();
        public void RemoveAdministrator(Administrator admin) => throw new NotImplementedException();
        public void MakeDiscount(IProduct item, int discountPercent) => throw new NotImplementedException();

        public void EditProduct(IProduct item)
        {
            throw new NotImplementedException();
        }
        public Administrator(string login, string password) : base(login, password) 
        {
            
        }
    }
}
