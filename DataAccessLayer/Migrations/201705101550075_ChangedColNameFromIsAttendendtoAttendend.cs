namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedColNameFromIsAttendendtoAttendend : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendance", "Attended", c => c.Boolean(nullable: false));
            DropColumn("dbo.Attendance", "IsAttendand");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendance", "IsAttendand", c => c.Boolean(nullable: false));
            DropColumn("dbo.Attendance", "Attended");
        }
    }
}
