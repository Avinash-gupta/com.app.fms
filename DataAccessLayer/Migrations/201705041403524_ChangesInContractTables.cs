namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInContractTables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContractInformation", "ClientId", c => c.String(nullable: false));
            AlterColumn("dbo.ContractInformation", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ContractInformation", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContractInformation", "EndDate", c => c.String());
            AlterColumn("dbo.ContractInformation", "StartDate", c => c.String());
            AlterColumn("dbo.ContractInformation", "ClientId", c => c.String());
        }
    }
}
