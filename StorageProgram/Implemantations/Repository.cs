using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;
using System.Data.Entity;
using StorageProgram.Interfaces;
using StorageProgram.Implemantations;

namespace StorageProgram.Interfaces
{
    class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T thingToAdd)
        {
            _dbContext.Set<T>().Add(thingToAdd);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int idToFind)
        {
            return _dbContext.Set<T>().Find(idToFind);
        }

        public void Remove(T idToRemove)
        {
            _dbContext.Set<T>().Remove(idToRemove);
        }
        
        public void RemoveRange(IEnumerable<T> removeRange)
        {
            _dbContext.Set<T>().RemoveRange(removeRange);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> input)
        {
            return _dbContext.Set<T>().SingleOrDefault(input);
        }
    }
}
