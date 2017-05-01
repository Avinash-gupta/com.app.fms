namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEmployeeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeAddressDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        AddressType = c.Int(nullable: false),
                        LandMark = c.String(),
                        VillageOrTown = c.String(),
                        PostOffice = c.String(),
                        Taluka = c.String(),
                        PoliceStation = c.String(),
                        State = c.String(),
                        District = c.String(),
                        Pincode = c.String(),
                        DateSinceResiding = c.DateTime(nullable: false),
                        PeriodOfStay = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeBankDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        BankName = c.String(),
                        BankAccountNo = c.Int(nullable: false),
                        BranchName = c.String(),
                        IFSCCode = c.String(),
                        BranchCode = c.Int(nullable: false),
                        BankCodeNo = c.Int(nullable: false),
                        BankAppNo = c.Int(nullable: false),
                        RegionCode = c.Int(nullable: false),
                        InsuranceNominee = c.String(),
                        BankCardReference = c.String(),
                        NomineeDateOfBirth = c.DateTime(nullable: false),
                        NomineeRelation = c.String(),
                        InsuranceCover = c.String(),
                        InsDebitAmount = c.Int(nullable: false),
                        UANNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeEducationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        Qualification = c.String(),
                        Description = c.String(),
                        NameAndAddressOfCollege = c.String(),
                        Board = c.String(),
                        YearOfStudy = c.Int(nullable: false),
                        Result = c.String(),
                        Percentage = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeExService",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        EmpExService = c.Boolean(nullable: false),
                        ServiceNo = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        DateOfEnrollment = c.DateTime(nullable: false),
                        DateOfDischarge = c.DateTime(nullable: false),
                        Crops = c.String(),
                        Trade = c.String(),
                        MedicalCategory = c.String(),
                        ReasonOfDischarge = c.String(),
                        Conduct = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeFamilyDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        Name = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        RelationShip = c.String(),
                        Occupation = c.String(),
                        PFNominee = c.Boolean(nullable: false),
                        ESiNominee = c.Boolean(nullable: false),
                        ResidingWithRelation = c.Boolean(nullable: false),
                        PlaceOfResidence = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        RefNameAndAddress1 = c.String(),
                        RefNameAndAddress2 = c.String(),
                        BloodGroup = c.String(),
                        PhysicalRemarks = c.String(),
                        IdentificationMarks1 = c.String(),
                        IdentificationMarks2 = c.String(),
                        SpeciallyAbled = c.Boolean(nullable: false),
                        ApplicationCategory = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeePhysicalStandard",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        HairColour = c.String(),
                        ChestUnExpand = c.Int(nullable: false),
                        ChestExpand = c.Int(nullable: false),
                        EyeColour = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeePolicyRecord",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        PoliceVerificationNumber = c.String(),
                        IsVerfied = c.Boolean(nullable: false),
                        NearestPoliceStation = c.String(),
                        IsCriminalOffence = c.Boolean(nullable: false),
                        IsCrimianalProceeding = c.Boolean(nullable: false),
                        IsCriminalArrestWarrant = c.Boolean(nullable: false),
                        CriminalOffCourtName = c.String(),
                        CriminalOffCaseNo = c.String(),
                        CriminalOffence = c.String(),
                        CriminalProCourtName = c.String(),
                        CriminalProCaseNo = c.String(),
                        CriminalProOffence = c.String(),
                        CriminalArrestCourtName = c.String(),
                        CriminalArrestCaseNo = c.String(),
                        CriminalArrestOffence = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeePreviousExperience",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        RegionCode = c.String(),
                        EmployeeCode = c.String(),
                        Extension = c.String(),
                        Designation = c.String(),
                        CompanyNameAndAddress = c.String(),
                        YearsOfExperience = c.Int(nullable: false),
                        PFNo = c.Int(nullable: false),
                        ESINo = c.Int(nullable: false),
                        DateOfResignation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeProofs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        ProofType = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        KYCName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeSalaryDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        AdditionalAmount = c.Int(nullable: false),
                        FoodAllowance = c.Int(nullable: false),
                        NoOfDays = c.String(),
                        Basic = c.Int(nullable: false),
                        DA = c.Int(nullable: false),
                        HRA = c.Int(nullable: false),
                        Conveyance = c.Int(nullable: false),
                        CCA = c.Int(nullable: false),
                        LA = c.Int(nullable: false),
                        Gratuity = c.Int(nullable: false),
                        Bonus = c.Int(nullable: false),
                        WA = c.Int(nullable: false),
                        OA = c.Int(nullable: false),
                        NFHs = c.Int(nullable: false),
                        SplAllowance = c.Int(nullable: false),
                        RC = c.Int(nullable: false),
                        CS = c.Int(nullable: false),
                        OTRate = c.Int(nullable: false),
                        Nots = c.String(),
                        TravellingAllowance = c.Int(nullable: false),
                        PerformanceAllowance = c.Int(nullable: false),
                        MobileAllowance = c.Int(nullable: false),
                        MedicalAllowance = c.Int(nullable: false),
                        PFDeduct = c.Boolean(nullable: false),
                        PTDeduct = c.Boolean(nullable: false),
                        EPFNo = c.Int(nullable: false),
                        PFEnrollDate = c.DateTime(nullable: false),
                        ESIDeduct = c.Boolean(nullable: false),
                        ESINo = c.Int(nullable: false),
                        ESIDispName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.EmployeePersonalInfo", "EmpID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeePersonalInfo", "EmpID", c => c.String(nullable: false));
            DropTable("dbo.EmployeeSalaryDetails");
            DropTable("dbo.EmployeeProofs");
            DropTable("dbo.EmployeePreviousExperience");
            DropTable("dbo.EmployeePolicyRecord");
            DropTable("dbo.EmployeePhysicalStandard");
            DropTable("dbo.EmployeeInfo");
            DropTable("dbo.EmployeeFamilyDetails");
            DropTable("dbo.EmployeeExService");
            DropTable("dbo.EmployeeEducationDetails");
            DropTable("dbo.EmployeeBankDetails");
            DropTable("dbo.EmployeeAddressDetails");
        }
    }
}
