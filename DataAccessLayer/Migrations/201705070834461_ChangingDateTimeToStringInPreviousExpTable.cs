namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingDateTimeToStringInPreviousExpTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeePreviousExperience", "DateOfResignation", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeePreviousExperience", "DateOfResignation", c => c.DateTime(nullable: false));
        }
    }
}
