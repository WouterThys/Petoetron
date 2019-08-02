namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer.PetoetronContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayer.PetoetronContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(new Classes.Customer { Id = 1, Code = "UNKNOWN", Description = "Unknown" });
            context.MaterialTypes.AddOrUpdate(new Classes.MaterialType { Id = 1, Code = "UNKNOWN", Description = "Unknown" });
            context.Materials.AddOrUpdate(new Classes.Material { Id = 1, Code = "UNKNOWN", Description = "Unknown", TypeId = 1 });
            
        }
    }
}
