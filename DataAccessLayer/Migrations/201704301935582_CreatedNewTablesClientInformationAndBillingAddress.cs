namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreatedNewTablesClientInformationAndBillingAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillingDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.String(),
                        LineOne = c.String(),
                        LineTwo = c.String(),
                        LineThree = c.String(),
                        LineFour = c.String(),
                        LineFive = c.String(),
                        LineSix = c.String(),
                        Description = c.String(),
                        SubUnit = c.String(),
                        MainUnit = c.String(),
                        Invoice = c.String(),
                        PaySheet = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientInformation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.String(),
                        Name = c.String(),
                        ShortName = c.String(),
                        Segment = c.String(),
                        ContactPerson = c.String(),
                        PersonDesignation = c.String(),
                        PhoneNos = c.Int(nullable: false),
                        LandLineNo = c.Int(nullable: false),
                        EmailId = c.String(),
                        FaxNo = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        UpdatedDateTim = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientInformation");
            DropTable("dbo.BillingDetails");
        }
    }
}
