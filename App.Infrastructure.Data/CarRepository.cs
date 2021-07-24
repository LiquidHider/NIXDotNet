using System;
using System.Collections.Generic;
using App.Domain.Core;
using App.Domain.Interfaces;

namespace App.Infrastructure.Data
{
    public class CarRepository : IRepository<Car>
    {
        public void Create(Car item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public void Dispose()
        {
            throw new NotImplementedException();

        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Car item)
        {
            throw new NotImplementedException();
        }
    }
}
