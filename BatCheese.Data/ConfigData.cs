namespace BatCheese.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ConfigData : DbContext
    {
        public ConfigData()
            : base("name=ConfigData")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}