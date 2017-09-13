using BatCheese.Data.AgentService;
using BatCheese.Repository.Wcf;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace BatCheese.Web.IOC
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAgentServiceRepository>().To<AgentServiceRepository>();
        }
    }
}