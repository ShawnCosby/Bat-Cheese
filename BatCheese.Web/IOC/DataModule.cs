﻿using BatCheese.Data.AgentService;
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
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<AgentServiceClient>().ToSelf().InRequestScope();
            this.Bind<IAgentServiceClientFactory>().ToFactory().InRequestScope();
        }
    }
}