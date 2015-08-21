using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTraining.Models
{
    public class MVCTrainingDb : DbContext
    {
        public MVCTrainingDb()
            : base("name=DefaultConnection")
        { }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
} 