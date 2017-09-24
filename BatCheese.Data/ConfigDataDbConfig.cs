using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace BatCheese.Data
{
    internal sealed class ConfigDataDbConfig : DbConfiguration
    {
        public ConfigDataDbConfig()
        {
            //Note: this execution strategy inherits from DbExecutionStrategy and will retry on
            //      exceptions that are known to be possibly transient when working with SqlAzure.
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}
