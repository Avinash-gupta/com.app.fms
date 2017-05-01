namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsActiveColumntoClientInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientInformation", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientInformation", "IsActive");
        }
    }
}
