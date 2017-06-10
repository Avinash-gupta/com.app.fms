namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewColumnsToAttendanceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendance", "Designation", c => c.String());
            AddColumn("dbo.Attendance", "Remarks", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendance", "Remarks");
            DropColumn("dbo.Attendance", "Designation");
        }
    }
}
