using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BatCheese.Repository
{
    public interface IWcfRepository<TService, TClient> where TClient : class
    {
        TimeSpan Timeout { get; set; }
    }
}
