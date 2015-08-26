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
        }

        protected override void Seed(MVCTraining.Models.MVCTrainingDb context)
        {
            for (var i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Models.Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            }

        }
    }
}
