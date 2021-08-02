namespace GroupAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkeys : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.IndividualWalkService", "LocationId");
            CreateIndex("dbo.ScheduledWalks", "ServiceId");
            CreateIndex("dbo.ScheduledWalks", "WalkerId");
            CreateIndex("dbo.ScheduledWalks", "PetId");
            AddForeignKey("dbo.IndividualWalkService", "LocationId", "dbo.Location", "LocationId", cascadeDelete: true);
            AddForeignKey("dbo.ScheduledWalks", "ServiceId", "dbo.IndividualWalkService", "ServiceId", cascadeDelete: true);
            AddForeignKey("dbo.ScheduledWalks", "PetId", "dbo.Pet", "PetId", cascadeDelete: true);
            AddForeignKey("dbo.ScheduledWalks", "WalkerId", "dbo.Walker", "WalkerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScheduledWalks", "WalkerId", "dbo.Walker");
            DropForeignKey("dbo.ScheduledWalks", "PetId", "dbo.Pet");
            DropForeignKey("dbo.ScheduledWalks", "ServiceId", "dbo.IndividualWalkService");
            DropForeignKey("dbo.IndividualWalkService", "LocationId", "dbo.Location");
            DropIndex("dbo.ScheduledWalks", new[] { "PetId" });
            DropIndex("dbo.ScheduledWalks", new[] { "WalkerId" });
            DropIndex("dbo.ScheduledWalks", new[] { "ServiceId" });
            DropIndex("dbo.IndividualWalkService", new[] { "LocationId" });
        }
    }
}
