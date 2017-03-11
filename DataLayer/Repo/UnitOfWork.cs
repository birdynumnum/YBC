using DataLayer.Context;

namespace DataLayer.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbfactory;
        private CardEntities context;

        public CardEntities Context
        {
            get { return context ?? (context = dbfactory.Init()); }
        }

        public UnitOfWork(IDbFactory factory)
        {
            dbfactory = factory;
        }

        public void Commit()
        {
            Context.Commit();
        }
    }
}
