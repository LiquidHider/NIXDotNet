using System;
using System.Collections.Generic;
using System.Linq;
using App.Domain.Interfaces;
namespace App.Infrastructure.Data
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ApplicationContext _context; // will be DbContext
        public string DataSavingPath { get; private set; }
        public List<T> _dbSet; // DbSet<T>
        public GenericRepository(ApplicationContext context, List<T> dbSet)// DbContext
        {
            _context = context;
            _dbSet = dbSet;
            DataSavingPath = _context.DataPath;
        }
        public void Create(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public void Delete(int id) 
        {
            _dbSet.RemoveAt(id);
            _context.SaveChanges();
        }

        public IEnumerable<T> Get() => _dbSet;

        public T GetById(int id) => _dbSet.Where((x,ID) => id == ID).First();
        public void Update(T item)
        {
            throw new NotImplementedException(); // for db context, (CRUD pattern)
        } 
        public void Dispose() => GC.Collect();
    }
}
