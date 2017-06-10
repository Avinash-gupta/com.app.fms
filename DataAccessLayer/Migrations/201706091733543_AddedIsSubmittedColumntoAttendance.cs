namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsSubmittedColumntoAttendance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendance", "IsSubmitted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendance", "IsSubmitted");
        }
    }
}
