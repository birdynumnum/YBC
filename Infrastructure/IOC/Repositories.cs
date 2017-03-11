using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using DataLayer.Repo;

namespace Infrastructure.IOC
{
    public class Repositories : Registry
    {
        public Repositories()
        {
            For<ICardRepository>().Use<CardRepository>();
            For<IUnitOfWork>().Use<UnitOfWork>();
        }
    }
}
