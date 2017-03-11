using System;
using System.Linq;
using System.Linq.Expressions;

namespace DataLayer.Repo
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        void Insert(T entity);
        void Delete(T entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        T GetById(int id);
    }
}
