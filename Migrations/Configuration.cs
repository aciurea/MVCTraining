using MVCTraining.Models;

namespace MVCTraining.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCTraining.Models.MVCTrainingDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MVCTraining.Models.MVCTrainingDb context)
        {
            for (var i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Restaurant
                    {
                        Name = i.ToString(),
                        City = "Nowwhere",
                        Country = "USA"
                    });
            }
        }
    }
}
