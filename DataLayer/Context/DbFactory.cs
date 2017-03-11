using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class DbFactory : Disposable,  IDbFactory
    {
        private CardEntities dbContext;

        public CardEntities Init()
        {
            return dbContext ?? (dbContext = new CardEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
