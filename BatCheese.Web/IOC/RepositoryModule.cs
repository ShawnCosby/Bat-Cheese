using BatCheese.Data.AgentService;
using BatCheese.Repository.Wcf;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using Ninject.Planning.Targets;
using Ninject.Web.Common;
using System;
using System.ServiceModel;

namespace BatCheese.Web.IOC
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            var binding = this.Bind<IAgentServiceRepository>().To<AgentServiceRepository>().InRequestScope();

            binding.WithConstructorArgument("client", new Func<IContext, ITarget, object>((ctx, trg) =>
            {
                var factory = ctx.Kernel.Get<IAgentServiceClientFactory>();

                var httpBinding = new WSHttpBinding();
                httpBinding.MaxReceivedMessageSize = int.MaxValue;

                var id = new SpnEndpointIdentity("host/scdev2.recordlion.com");

                var uri = new Uri("http://scdev2:8050/agentservice", UriKind.Absolute);

                var endpoint = new EndpointAddress(uri, id);

                return factory.CreateAgentServiceClient(httpBinding, endpoint);
            }));
        }
    }
}