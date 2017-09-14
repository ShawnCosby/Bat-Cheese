using BatCheese.Domain.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace BatCheese.Web.IOC
{
    public class DomainModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAgentService>().To<AgentService>().InRequestScope();
        }
    }
}