namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContractsTableColumnstoDateTimeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContractInformation", "ValidityDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ContractPaysheet", "ExpectedDateOfReceipt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContractPaysheet", "ExpectedDateOfReceipt", c => c.String());
            AlterColumn("dbo.ContractInformation", "ValidityDate", c => c.String());
        }
    }
}
