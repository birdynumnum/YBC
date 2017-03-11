using DataLayer.Context;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataLayer.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CardEntities dataContext;
        private readonly IDbSet<T> DbSet;
        protected IDbFactory dbFactory { get; set; }

        public CardEntities DbContext
        {
            get { return dataContext ?? (dataContext = dbFactory.Init()); }
        }

        protected Repository(IDbFactory DbFactory)
        {
            dbFactory = DbFactory;

            //Creates the CardContext here!!!
            DbSet = DbContext.Set<T>();
        }

        public void Insert(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }
    }
}
