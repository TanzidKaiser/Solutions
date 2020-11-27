using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSolution.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private SolutionContext _entities = null;
        private DbSet<T> _objectSet = null;

        public Repository(SolutionContext entities)
        {
            _entities = entities;
            _objectSet = entities.Set<T>();
        }

        public IQueryable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _objectSet.Where(predicate).AsQueryable();
            }

            return _objectSet.AsQueryable();
        }

        public T GetById(Func<T, bool> predicate)
        {
            return _objectSet.First(predicate);
        }

        //public T GetById(int Id)
        //{
        //    return _objectSet.First(predicate);
        //}

        public void Add(T entity)
        {
            _objectSet.Add(entity);
        }

        public void Update(T entity)
        {
            //_objectSet.Attach(entity);           
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _objectSet.Remove(entity);
        }
    }
}
