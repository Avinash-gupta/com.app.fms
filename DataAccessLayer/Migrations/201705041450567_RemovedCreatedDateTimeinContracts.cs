namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCreatedDateTimeinContracts : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ContractInformation", "CreatedDateTime");
            DropColumn("dbo.ContractInformation", "UpdatedDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContractInformation", "UpdatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.ContractInformation", "CreatedDateTime", c => c.DateTime(nullable: false));
        }
    }
}
