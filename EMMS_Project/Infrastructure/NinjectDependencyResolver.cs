using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMMS_Project.Abstract;
using EMMS_Project.Concrete;
using System.Web.Mvc;

namespace EMMS_Project.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<INormalRepository>().To<AdoNetNormalRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}