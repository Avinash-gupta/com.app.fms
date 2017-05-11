namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewTableForAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractId = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        EmployeeName = c.String(),
                        AttendanceDate = c.DateTime(nullable: false),
                        IsAttendand = c.Boolean(nullable: false),
                        NoOfHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Attendance");
        }
    }
}
