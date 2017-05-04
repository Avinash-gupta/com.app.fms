namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdatedSchemaForEmployeeProofsAndEmployeeAddressDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeAddressDetails", "TmpAddressLine1", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "TmpAddressLine2", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "TmpLandMark", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "TmpPostOffice", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "TmpPoliceStation", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "TmpState", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "TmpDistrict", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "TmpPincode", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PerAddressLine1", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PerAddressLine2", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PerLandMark", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PerPostOffice", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PerState", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PerDistrict", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PerPincode", c => c.String());
            AddColumn("dbo.EmployeeProofs", "AadharCardNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "AadharCardName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "DrivingLicenseNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "DrivingLicenseName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "VoterIDNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "VoterIDName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "RationCardNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "RationCardName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "PancardNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "PancardName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "BankPassBookNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "BankPassBookName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ElectricityBillNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ElectricityBillName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "EsicCardNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "EsicCardName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ExServiceNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "EMPExService", c => c.Boolean(nullable: false));
            AddColumn("dbo.EmployeeProofs", "ExServicedateOfEnrollment", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ExServiceRank", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ExServiceCrops", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ExServicemedicalCategory", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ExServiceconduct", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ExServiceTrade", c => c.String());
            AddColumn("dbo.EmployeeProofs", "ExServicedateOfDischarge", c => c.String());
            AddColumn("dbo.EmployeeProofs", "OtherCardsNumber", c => c.String());
            AddColumn("dbo.EmployeeProofs", "OtherCardsName", c => c.String());
            DropColumn("dbo.EmployeeAddressDetails", "AddressType");
            DropColumn("dbo.EmployeeAddressDetails", "LandMark");
            DropColumn("dbo.EmployeeAddressDetails", "VillageOrTown");
            DropColumn("dbo.EmployeeAddressDetails", "PostOffice");
            DropColumn("dbo.EmployeeAddressDetails", "Taluka");
            DropColumn("dbo.EmployeeAddressDetails", "PoliceStation");
            DropColumn("dbo.EmployeeAddressDetails", "State");
            DropColumn("dbo.EmployeeAddressDetails", "District");
            DropColumn("dbo.EmployeeAddressDetails", "Pincode");
            DropColumn("dbo.EmployeeAddressDetails", "DateSinceResiding");
            DropColumn("dbo.EmployeeAddressDetails", "PeriodOfStay");
            DropColumn("dbo.EmployeeAddressDetails", "Phone");
            DropColumn("dbo.EmployeeProofs", "ProofType");
            DropColumn("dbo.EmployeeProofs", "Number");
            DropColumn("dbo.EmployeeProofs", "KYCName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeProofs", "KYCName", c => c.String());
            AddColumn("dbo.EmployeeProofs", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeProofs", "ProofType", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeAddressDetails", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeAddressDetails", "PeriodOfStay", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeAddressDetails", "DateSinceResiding", c => c.DateTime(nullable: false));
            AddColumn("dbo.EmployeeAddressDetails", "Pincode", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "District", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "State", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PoliceStation", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "Taluka", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "PostOffice", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "VillageOrTown", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "LandMark", c => c.String());
            AddColumn("dbo.EmployeeAddressDetails", "AddressType", c => c.Int(nullable: false));
            DropColumn("dbo.EmployeeProofs", "OtherCardsName");
            DropColumn("dbo.EmployeeProofs", "OtherCardsNumber");
            DropColumn("dbo.EmployeeProofs", "ExServicedateOfDischarge");
            DropColumn("dbo.EmployeeProofs", "ExServiceTrade");
            DropColumn("dbo.EmployeeProofs", "ExServiceconduct");
            DropColumn("dbo.EmployeeProofs", "ExServicemedicalCategory");
            DropColumn("dbo.EmployeeProofs", "ExServiceCrops");
            DropColumn("dbo.EmployeeProofs", "ExServiceRank");
            DropColumn("dbo.EmployeeProofs", "ExServicedateOfEnrollment");
            DropColumn("dbo.EmployeeProofs", "EMPExService");
            DropColumn("dbo.EmployeeProofs", "ExServiceNumber");
            DropColumn("dbo.EmployeeProofs", "EsicCardName");
            DropColumn("dbo.EmployeeProofs", "EsicCardNumber");
            DropColumn("dbo.EmployeeProofs", "ElectricityBillName");
            DropColumn("dbo.EmployeeProofs", "ElectricityBillNumber");
            DropColumn("dbo.EmployeeProofs", "BankPassBookName");
            DropColumn("dbo.EmployeeProofs", "BankPassBookNumber");
            DropColumn("dbo.EmployeeProofs", "PancardName");
            DropColumn("dbo.EmployeeProofs", "PancardNumber");
            DropColumn("dbo.EmployeeProofs", "RationCardName");
            DropColumn("dbo.EmployeeProofs", "RationCardNumber");
            DropColumn("dbo.EmployeeProofs", "VoterIDName");
            DropColumn("dbo.EmployeeProofs", "VoterIDNumber");
            DropColumn("dbo.EmployeeProofs", "DrivingLicenseName");
            DropColumn("dbo.EmployeeProofs", "DrivingLicenseNumber");
            DropColumn("dbo.EmployeeProofs", "AadharCardName");
            DropColumn("dbo.EmployeeProofs", "AadharCardNumber");
            DropColumn("dbo.EmployeeAddressDetails", "PerPincode");
            DropColumn("dbo.EmployeeAddressDetails", "PerDistrict");
            DropColumn("dbo.EmployeeAddressDetails", "PerState");
            DropColumn("dbo.EmployeeAddressDetails", "PerPostOffice");
            DropColumn("dbo.EmployeeAddressDetails", "PerLandMark");
            DropColumn("dbo.EmployeeAddressDetails", "PerAddressLine2");
            DropColumn("dbo.EmployeeAddressDetails", "PerAddressLine1");
            DropColumn("dbo.EmployeeAddressDetails", "TmpPincode");
            DropColumn("dbo.EmployeeAddressDetails", "TmpDistrict");
            DropColumn("dbo.EmployeeAddressDetails", "TmpState");
            DropColumn("dbo.EmployeeAddressDetails", "TmpPoliceStation");
            DropColumn("dbo.EmployeeAddressDetails", "TmpPostOffice");
            DropColumn("dbo.EmployeeAddressDetails", "TmpLandMark");
            DropColumn("dbo.EmployeeAddressDetails", "TmpAddressLine2");
            DropColumn("dbo.EmployeeAddressDetails", "TmpAddressLine1");
        }
    }
}
