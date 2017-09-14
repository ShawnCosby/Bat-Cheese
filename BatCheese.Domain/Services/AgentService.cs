using BatCheese.Repository.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatCheese.Domain.Services
{
    public class AgentService : IAgentService
    {
        private IAgentServiceRepository repo;

        public AgentService(IAgentServiceRepository repository)
        {
            this.repo = repository;
        }

        public async Task GetErrorBatchesAsync()
        {
            var task = this.repo.GetErrorBatchesAsync();

            var data = await task;

            return;
        }
    }
}
