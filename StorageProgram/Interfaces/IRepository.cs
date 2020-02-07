using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace StorageProgram.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Remove(T id);

        void RemoveRange(IEnumerable<T> removeRange);

        T SingleOrDefault(Expression<Func<T, bool>> input);
    }
}
