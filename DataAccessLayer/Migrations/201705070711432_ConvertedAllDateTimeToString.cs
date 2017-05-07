namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertedAllDateTimeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeBankDetails", "NomineeDateOfBirth", c => c.String());
            AlterColumn("dbo.EmployeeExService", "DateOfEnrollment", c => c.String());
            AlterColumn("dbo.EmployeeExService", "DateOfDischarge", c => c.String());
            AlterColumn("dbo.EmployeeFamilyDetails", "DateofBirth", c => c.String());
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfBirth", c => c.String());
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfInterview", c => c.String());
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfJoining", c => c.String());
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfLeaving", c => c.String());
            AlterColumn("dbo.EmployeePersonalInfo", "IdCardIssuedDate", c => c.String());
            AlterColumn("dbo.EmployeePersonalInfo", "IdCardValidTill", c => c.String());
            AlterColumn("dbo.EmployeeSalaryDetails", "PFEnrollDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeSalaryDetails", "PFEnrollDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeePersonalInfo", "IdCardValidTill", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeePersonalInfo", "IdCardIssuedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfLeaving", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfJoining", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfInterview", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeePersonalInfo", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeeFamilyDetails", "DateofBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeeExService", "DateOfDischarge", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeeExService", "DateOfEnrollment", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmployeeBankDetails", "NomineeDateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
