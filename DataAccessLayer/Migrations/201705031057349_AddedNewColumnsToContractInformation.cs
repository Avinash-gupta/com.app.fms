namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewColumnsToContractInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContractInformation", "CreatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.ContractInformation", "UpdatedDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContractInformation", "UpdatedDateTime");
            DropColumn("dbo.ContractInformation", "CreatedDateTime");
        }
    }
}
