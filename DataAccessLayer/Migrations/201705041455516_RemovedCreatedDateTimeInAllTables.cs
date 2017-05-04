namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCreatedDateTimeInAllTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClientInformation", "CreatedDateTime");
            DropColumn("dbo.ClientInformation", "UpdatedDateTim");
            DropColumn("dbo.EmployeePersonalInfo", "CreatedDateTime");
            DropColumn("dbo.EmployeePersonalInfo", "UpdatedDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeePersonalInfo", "UpdatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.EmployeePersonalInfo", "CreatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.ClientInformation", "UpdatedDateTim", c => c.DateTime(nullable: false));
            AddColumn("dbo.ClientInformation", "CreatedDateTime", c => c.DateTime(nullable: false));
        }
    }
}
