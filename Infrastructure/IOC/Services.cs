using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using ServiceLayer;

namespace Infrastructure.IOC
{
    public class Services : Registry
    {
        public Services()
        {
            For<IBusinessCardService>().Use<BusinessCardService>();
        }
    }
}
