namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmployeePersonalInfoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeePersonalInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpID = c.String(nullable: false),
                        Title = c.String(),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        MaritalStatus = c.String(nullable: false),
                        Status = c.String(),
                        Qualification = c.String(),
                        Designation = c.String(nullable: false),
                        DateOfInterview = c.DateTime(nullable: false),
                        DateOfJoining = c.DateTime(nullable: false),
                        PhoneNo = c.Int(nullable: false),
                        DateOfLeaving = c.DateTime(nullable: false),
                        MotherTounge = c.String(),
                        LanguagesKnown = c.String(),
                        Nationality = c.String(),
                        Religion = c.String(),
                        FatherName = c.String(),
                        FatherOccupation = c.String(),
                        MotherName = c.String(),
                        SpouseName = c.String(),
                        Branch = c.String(),
                        Division = c.String(),
                        Department = c.String(),
                        ReportingManager = c.String(),
                        SitePostedTo = c.String(),
                        GrossSalary = c.String(),
                        PSARAEmpCode = c.String(),
                        Email = c.String(),
                        IdCardIssuedDate = c.DateTime(nullable: false),
                        IdCardValidTill = c.DateTime(nullable: false),
                        ClientEmployeeId = c.Int(nullable: false),
                        PreviousEmployer = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false),
                        UpdatedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeePersonalInfo");
        }
    }
}
