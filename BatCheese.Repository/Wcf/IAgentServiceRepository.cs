using BatCheese.Data.AgentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatCheese.Repository.Wcf
{
    public interface IAgentServiceRepository : IDisposable, IWcfRepository<IAgentService, AgentServiceClient>
    {
        Task<ActivitiesToProcess> GetErrorBatchesAsync();
    }
}
