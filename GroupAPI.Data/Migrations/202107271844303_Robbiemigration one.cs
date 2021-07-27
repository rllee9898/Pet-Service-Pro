namespace GroupAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Robbiemigrationone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IndividualWalkService",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        WalkLength = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationStart = c.String(),
                        LocationEnd = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.ScheduledWalks",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        ServiceId = c.Int(nullable: false),
                        WalkerId = c.Int(nullable: false),
                        PetId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Walker",
                c => new
                    {
                        WalkerId = c.Int(nullable: false, identity: true),
                        WalkerName = c.String(),
                    })
                .PrimaryKey(t => t.WalkerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Walker");
            DropTable("dbo.ScheduledWalks");
            DropTable("dbo.Location");
            DropTable("dbo.IndividualWalkService");
        }
    }
}
