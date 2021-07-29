namespace GroupAPI.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GroupAPI.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GroupAPI.Data.ApplicationDbContext";
        }

        protected override void Seed(GroupAPI.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Walkers.AddOrUpdate(
              p => p.WalkerName,
              new Walker { WalkerName = "Frank" },
              new Walker { WalkerName = "Jerry" },
              new Walker { WalkerName = "James" },
              new Walker { WalkerName = "Mary" },
              new Walker { WalkerName = "Robert" },
              new Walker { WalkerName = "Susan" },
              new Walker { WalkerName = "Jennifer" },
              new Walker { WalkerName = "Richard" },
              new Walker { WalkerName = "Ashley" },
              new Walker { WalkerName = "Paul" },
              new Walker { WalkerName = "Emily" },
              new Walker { WalkerName = "Micheal" }
            );

            context.Locations.AddOrUpdate(
              p => p.LocationStart,
              new Location { LocationStart = "Eagle Creek Ornithology Center", LocationEnd = "Lily Lake", City = "Indianapolis", State = "Indiana" },
              new Location { LocationStart = "Alpine Center", LocationEnd = "Kawuneeche Valley", City = "Breckenridge", State = "Colorado" },
              new Location { LocationStart = "Yosemite Falls", LocationEnd = "Half Dome", City = "Yosemite", State = "Colorado" },
              new Location { LocationStart = "Haleakala Volcano", LocationEnd = "Wailea Resort", City = "Maui", State = "Hawaii" },
              new Location { LocationStart = "Cadillac Mountain", LocationEnd = "Stewman's", City = "Acadia", State = "Maine" },
              new Location { LocationStart = "Shark Valley", LocationEnd = "Anhinga Trail", City = "Everglades", State = "Florida" }
              );

            context.Pets.AddOrUpdate(
              p => p.PetName,
            new Pet { PetType = "Dog", PetName = "Bailey" },
            new Pet { PetType = "Cat", PetName = "Max" },
            new Pet { PetType = "Bird", PetName = "Bella" },
            new Pet { PetType = "Fish", PetName = "Charlie" },
            new Pet { PetType = "Chinchilla", PetName = "Roxy" },
            new Pet { PetType = "Turtle", PetName = "Sam" },
            new Pet { PetType = "Hermit Crab", PetName = "Oscar" },
            new Pet { PetType = "Parrot", PetName = "Lily" },
            new Pet { PetType = "Guinea Pig", PetName = "Maggie" },
            new Pet { PetType = "Ferret", PetName = "Daisy" },
            new Pet { PetType = "Giraffe", PetName = "Rocky" }
            );

            context.IndividualWalkServices.AddOrUpdate(
              p => p.ServiceName,
              new IndividualWalkService { ServiceName = "Walk", WalkLength = 7, Price = 17.42m, LocationId = 2 },
              new IndividualWalkService { ServiceName = "LongWalk", WalkLength = 15, Price = 24.42m, LocationId = 1 },
              new IndividualWalkService { ServiceName = "ReallyLongWalk", WalkLength = 32, Price = 37.42m, LocationId = 2 }
              );
        }
    }
}
