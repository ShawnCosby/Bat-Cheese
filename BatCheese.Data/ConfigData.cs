namespace BatCheese.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    [DbConfigurationType(typeof(ConfigDataDbConfig))]
    public class ConfigData : DbContext
    {
        static ConfigData()
        {
            Database.SetInitializer(new ConfigDataInitializer());
        }

        public ConfigData()
            : base("name=ConfigData")
        {
        }

        public virtual IDbSet<Server> Servers { get; set; }
    }
}