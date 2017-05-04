namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ClientIdIsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BillingDetails", "ClientId", c => c.String(nullable: false));
            AlterColumn("dbo.ClientInformation", "ClientId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientInformation", "ClientId", c => c.String());
            AlterColumn("dbo.BillingDetails", "ClientId", c => c.String());
        }
    }
}
