namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateTimeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContractInformation", "StartDate", c => c.String());
            AlterColumn("dbo.ContractInformation", "EndDate", c => c.String());
            AlterColumn("dbo.ContractInformation", "ValidityDate", c => c.String());
            AlterColumn("dbo.ContractPaysheet", "ExpectedDateOfReceipt", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContractPaysheet", "ExpectedDateOfReceipt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ContractInformation", "ValidityDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ContractInformation", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ContractInformation", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
