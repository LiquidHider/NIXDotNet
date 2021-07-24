using System;
using System.Collections.Generic;
using System.Text;
using App.Domain.Core;

namespace App.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
        T GetById(int id);
        IEnumerable<T> GetList();
    }
}
