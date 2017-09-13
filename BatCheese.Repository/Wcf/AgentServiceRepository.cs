using BatCheese.Data.AgentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BatCheese.Repository.Wcf
{
    public sealed class AgentServiceRepository : WcfRepository<IAgentService, AgentServiceClient>,              
                                                 IAgentServiceRepository
    {
        public AgentServiceRepository(AgentServiceClient client) : base(client)
        {
        }

        public AgentServiceRepository(Func<AgentServiceClient> clientInitFunc) : base(clientInitFunc)
        {
        }


        public Task<ActivitiesToProcess> GetErrorBatchesAsync()
        {
            return this.Client.GetErrorBatchesAsync();
        }

    }
}
