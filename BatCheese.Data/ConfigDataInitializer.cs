using BatCheese.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatCheese.Data
{
    internal class ConfigDataInitializer : MigrateDatabaseToLatestVersion<ConfigData, ConfigDataMigrationConfig>
    {
        public ConfigDataInitializer()
        {
        }

        public ConfigDataInitializer(bool useSuppliedContext) : base(useSuppliedContext)
        {
        }

        public ConfigDataInitializer(string connectionStringName) : base(connectionStringName)
        {
        }

        public ConfigDataInitializer(bool useSuppliedContext, ConfigDataMigrationConfig configuration) : base(useSuppliedContext, configuration)
        {
        }
    }
}
