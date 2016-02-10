using System.Collections.Generic;
using OfficePool.Domain;

namespace OfficePool.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OfficePool.Repository.OfficePoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OfficePool.Repository.OfficePoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.            

            var departments = new List<Department>
            {
                new Department
                {
                    Name = "Finance"
                },
                new Department
                {
                    Name = "Information Technology"
                },
                new Department
                {
                    Name = "Membership"
                }
            };

            departments.ForEach(d => context.Departments.AddOrUpdate(di => di.Name, d));
            context.SaveChanges();
        }
    }
}