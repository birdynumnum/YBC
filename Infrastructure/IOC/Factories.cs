using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using DataLayer.Context;

namespace Infrastructure.IOC
{
    public class Factories : Registry
    {
        public Factories ()
    	{
            For<IDbFactory>().Use<DbFactory>();
	    }
    }
}
