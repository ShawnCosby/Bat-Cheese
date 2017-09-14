using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatCheese.Domain.Services
{
    public interface IAgentService
    {
        Task GetErrorBatchesAsync();
    }
}
