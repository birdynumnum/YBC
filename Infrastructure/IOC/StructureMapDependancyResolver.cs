using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using System.Web.Mvc;
using ServiceLayer.Null;
using NullGuard;

namespace Infrastructure.IOC
{
    public class StructureMapDependancyResolver : IDependencyResolver
    {
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return IoC.Container.GetAllInstances(serviceType).Cast<object>();
        }

        [return: AllowNull]
        public object GetService(Type serviceType)
        {
            if (serviceType == null)
            {
                return null;
            }
            
            return serviceType.IsAbstract || serviceType.IsInterface
                ? IoC.Container.TryGetInstance(serviceType)
                : IoC.Container.GetInstance(serviceType);
        }
    }
}
