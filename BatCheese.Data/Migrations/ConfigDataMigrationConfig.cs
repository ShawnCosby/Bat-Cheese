using System.Data.Entity.Migrations;

namespace BatCheese.Data.Migrations
{
    internal sealed class ConfigDataMigrationConfig : DbMigrationsConfiguration<ConfigData>
    {
        public ConfigDataMigrationConfig()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        //protected override void Seed(ConfigData context)
        //{
        //    base.Seed(context);
        //}
    }
}
