namespace GroupAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedschduledwalk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IndividualWalkService", "ServiceName", c => c.String(nullable: false));
            AlterColumn("dbo.Location", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Location", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Pet", "PetType", c => c.String(nullable: false));
            AlterColumn("dbo.Pet", "PetName", c => c.String(nullable: false));
            AlterColumn("dbo.ScheduledWalks", "EventName", c => c.String(nullable: false));
            AlterColumn("dbo.Walker", "WalkerName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Walker", "WalkerName", c => c.String());
            AlterColumn("dbo.ScheduledWalks", "EventName", c => c.String());
            AlterColumn("dbo.Pet", "PetName", c => c.String());
            AlterColumn("dbo.Pet", "PetType", c => c.String());
            AlterColumn("dbo.Location", "State", c => c.String());
            AlterColumn("dbo.Location", "City", c => c.String());
            AlterColumn("dbo.IndividualWalkService", "ServiceName", c => c.String());
        }
    }
}
