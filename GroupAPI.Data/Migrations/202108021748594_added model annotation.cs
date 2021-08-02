namespace GroupAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmodelannotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Location", "State", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Location", "State", c => c.String(nullable: false));
        }
    }
}
