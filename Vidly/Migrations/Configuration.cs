namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Movies.AddOrUpdate(m => m.Id,
                new Movie() { Id = 1, Name = "Shrek", GenreId = 1, ReleaseDate = new DateTime(2001, 04, 22), DateAdded = new DateTime(2020, 06, 10), NumberInStock = 20 },
                new Movie() { Id = 3, Name = "Iron Man", GenreId = 2, ReleaseDate = new DateTime(2008, 05, 02), DateAdded = new DateTime(2020, 06, 10), NumberInStock = 20 },
                new Movie() { Id = 2, Name = "Forgetting Sarah Marshal", GenreId = 3, ReleaseDate = new DateTime(2008, 04, 18), DateAdded = new DateTime(2020, 06, 10), NumberInStock = 20 },
                new Movie() { Id = 4, Name = "Conjuring", GenreId = 4, ReleaseDate = new DateTime(2013, 07, 19), DateAdded = new DateTime(2020, 06, 10), NumberInStock = 20 });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
