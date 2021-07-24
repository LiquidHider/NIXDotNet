using System;

namespace App.Services.Interfaces
{
    public interface IOrder<T> where T : class
    {
        void MakeOrder(T product);
    }
}
