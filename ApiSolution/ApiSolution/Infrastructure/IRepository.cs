using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSolution.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        IQueryable<T> GetAll(Func<T, bool> predicate = null);
        
        T GetById(Func<T, bool> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
