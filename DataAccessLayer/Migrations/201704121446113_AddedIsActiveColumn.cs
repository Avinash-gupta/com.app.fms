namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedIsActiveColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeePersonalInfo", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeePersonalInfo", "IsActive");
        }
    }
}
