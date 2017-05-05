namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDesignationsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EmployeePersonalInfo", "ContractId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeePersonalInfo", "ContractId");
            DropTable("dbo.Designations");
        }
    }
}
