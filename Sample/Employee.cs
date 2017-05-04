using System;
using System.Collections.Generic;

namespace Sample
{
    public class EmployeeEntity
    {
        public EmployeePersonalInfoEntity EmployeePersonalInfo { get; set; }
        public EmployeeInfoEntity EmployeeInfo { get; set; }
        public EmployeePhysicalStandardEntity EmployeePhysicalStandard { get; set; }
        public EmployeeAddressDetailsEntity EmployeeAddressDetails { get; set; }
        public EmployeeBankDetailsEntity EmployeeBankDetails { get; set; }
        public EmployeeSalaryDetailsEntity EmployeeSalaryDetails { get; set; }
        public EmployeeProofsEntity EmployeeProofs { get; set; }
        public EmployeeExServiceEntity EmployeeExService { get; set; }
        public List<EmployeeFamilyDetailsEntity> EmployeeFamilyDetails { get; set; }
        public List<EmployeeEducationDetailsEntity> EmployeeEducationDetails { get; set; }
        public List<EmployeePreviousExperienceEntity> EmployeePreviousExperience { get; set; }
        public EmployeePolicyRecordEntity EmployeePolicyRecord { get; set; }
    }

    public class EmployeePersonalInfoEntity
    {
        public int EmpID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Status { get; set; }
        public string Qualification { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfInterview { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int PhoneNo { get; set; }
        public DateTime DateOfLeaving { get; set; }
        public string MotherTounge { get; set; }
        public string LanguagesKnown { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string Branch { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string ReportingManager { get; set; }
        public string SitePostedTo { get; set; }
        public string GrossSalary { get; set; }
        public string PSARAEmpCode { get; set; }
        public string Email { get; set; }
        public DateTime IdCardIssuedDate { get; set; }
        public DateTime IdCardValidTill { get; set; }
        public int ClientEmployeeId { get; set; }
        public string PreviousEmployer { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }

    public class EmployeeInfoEntity
    {
        public string RefNameAndAddress1 { get; set; }
        public string RefNameAndAddress2 { get; set; }
        public string BloodGroup { get; set; }
        public string PhysicalRemarks { get; set; }
        public string IdentificationMarks1 { get; set; }
        public string IdentificationMarks2 { get; set; }
        public bool SpeciallyAbled { get; set; }
        public string ApplicationCategory { get; set; }
        public string Remarks { get; set; }
    }

    public class EmployeePhysicalStandardEntity
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public string HairColour { get; set; }
        public int ChestUnExpand { get; set; }
        public int ChestExpand { get; set; }
        public string EyeColour { get; set; }
    }

    public class EmployeeAddressDetailsEntity
    {
        public string TmpAddressLine1 { get; set; }
        public string TmpAddressLine2 { get; set; }
        public string TmpLandMark { get; set; }
        public string TmpPostOffice { get; set; }
        public string TmpPoliceStation { get; set; }
        public string TmpState { get; set; }
        public string TmpDistrict { get; set; }
        public string TmpPincode { get; set; }
        public string PerAddressLine1 { get; set; }
        public string PerAddressLine2 { get; set; }
        public string PerLandMark { get; set; }
        public string PerPostOffice { get; set; }
        public string PerState { get; set; }
        public string PerDistrict { get; set; }
        public string PerPincode { get; set; }
    }

    //public class EmployeeAddressDetailsEntity
    //{
    //    public AddressType AddressType { get; set; }
    //    public string LandMark { get; set; }
    //    public string VillageOrTown { get; set; }
    //    public string PostOffice { get; set; }
    //    public string Taluka { get; set; }
    //    public string PoliceStation { get; set; }
    //    public string State { get; set; }
    //    public string District { get; set; }
    //    public string Pincode { get; set; }
    //    public DateTime DateSinceResiding { get; set; }
    //    public int PeriodOfStay { get; set; }
    //    public int Phone { get; set; }
    //}

    public class EmployeeBankDetailsEntity
    {
        public string BankName { get; set; }
        public int BankAccountNo { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public int BranchCode { get; set; }
        public int BankCodeNo { get; set; }
        public int BankAppNo { get; set; }
        public int RegionCode { get; set; }
        public string InsuranceNominee { get; set; }
        public string BankCardReference { get; set; }
        public DateTime NomineeDateOfBirth { get; set; }
        public string NomineeRelation { get; set; }
        public string InsuranceCover { get; set; }
        public int InsDebitAmount { get; set; }
        public string UANNo { get; set; }
    }

    public class EmployeeSalaryDetailsEntity
    {
        public int AdditionalAmount { get; set; }
        public int FoodAllowance { get; set; }
        public string NoOfDays { get; set; }
        public int Basic { get; set; }
        public int DA { get; set; }
        public int HRA { get; set; }
        public int Conveyance { get; set; }
        public int CCA { get; set; }
        public int LA { get; set; }
        public int Gratuity { get; set; }
        public int Bonus { get; set; }
        public int WA { get; set; }
        public int OA { get; set; }
        public int NFHs { get; set; }
        public int SplAllowance { get; set; }
        public int RC { get; set; }
        public int CS { get; set; }
        public int OTRate { get; set; }
        public string Nots { get; set; }
        public int TravellingAllowance { get; set; }
        public int PerformanceAllowance { get; set; }
        public int MobileAllowance { get; set; }
        public int MedicalAllowance { get; set; }
        public bool PFDeduct { get; set; }
        public bool PTDeduct { get; set; }
        public int EPFNo { get; set; }
        public DateTime PFEnrollDate { get; set; }
        public bool ESIDeduct { get; set; }
        public int ESINo { get; set; }
        public string ESIDispName { get; set; }
    }


    public class EmployeeProofsEntity
    {
        public string AadharCardNumber { get; set; }
        public string AadharCardName { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string DrivingLicenseName { get; set; }
        public string VoterIDNumber { get; set; }
        public string VoterIDName { get; set; }
        public string RationCardNumber { get; set; }
        public string RationCardName { get; set; }
        public string PancardNumber { get; set; }
        public string PancardName { get; set; }
        public string BankPassBookNumber { get; set; }
        public string BankPassBookName { get; set; }
        public string ElectricityBillNumber { get; set; }
        public string ElectricityBillName { get; set; }
        public string EsicCardNumber { get; set; }
        public string EsicCardName { get; set; }
        public string ExServiceNumber { get; set; }
        public bool EMPExService { get; set; }
        public string ExServicedateOfEnrollment { get; set; }
        public string ExServiceRank { get; set; }
        public string ExServiceCrops { get; set; }
        public string ExServicemedicalCategory { get; set; }
        public string ExServiceconduct { get; set; }
        public string ExServiceTrade { get; set; }
        public string ExServicedateOfDischarge { get; set; }
        public string OtherCardsNumber { get; set; }
        public string OtherCardsName { get; set; }
    }


    //public class EmployeeProofsEntity
    //{
    //    public ProofType ProofType { get; set; }
    //    public int Number { get; set; }
    //    public string KYCName { get; set; }
    //}

    public class EmployeeExServiceEntity
    {
        public bool EmpExService { get; set; }
        public int ServiceNo { get; set; }
        public int Rank { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public DateTime DateOfDischarge { get; set; }
        public string Crops { get; set; }
        public string Trade { get; set; }
        public string MedicalCategory { get; set; }
        public string ReasonOfDischarge { get; set; }
        public string Conduct { get; set; }
    }

    public class EmployeeFamilyDetailsEntity
    {
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Age { get; set; }
        public string RelationShip { get; set; }
        public string Occupation { get; set; }
        public bool PFNominee { get; set; }
        public bool ESiNominee { get; set; }
        public bool ResidingWithRelation { get; set; }
        public string PlaceOfResidence { get; set; }
    }

    public class EmployeeEducationDetailsEntity
    {
        public string Qualification { get; set; }
        public string Description { get; set; }
        public string NameAndAddressOfCollege { get; set; }
        public string Board { get; set; }
        public int YearOfStudy { get; set; }
        public string Result { get; set; }
        public float Percentage { get; set; }
    }

    public class EmployeePreviousExperienceEntity
    {
        public string RegionCode { get; set; }
        public string EmployeeCode { get; set; }
        public string Extension { get; set; }
        public string Designation { get; set; }
        public string CompanyNameAndAddress { get; set; }
        public int YearsOfExperience { get; set; }
        public int PFNo { get; set; }
        public int ESINo { get; set; }
        public DateTime DateOfResignation { get; set; }
    }

    public class EmployeePolicyRecordEntity
    {
        public string PoliceVerificationNumber { get; set; }
        public bool IsVerfied { get; set; }
        public string NearestPoliceStation { get; set; }
        public bool IsCriminalOffence { get; set; }
        public bool IsCrimianalProceeding { get; set; }
        public bool IsCriminalArrestWarrant { get; set; }
        public string CriminalOffCourtName { get; set; }
        public string CriminalOffCaseNo { get; set; }
        public string CriminalOffence { get; set; }
        public string CriminalProCourtName { get; set; }
        public string CriminalProCaseNo { get; set; }
        public string CriminalProOffence { get; set; }
        public string CriminalArrestCourtName { get; set; }
        public string CriminalArrestCaseNo { get; set; }
        public string CriminalArrestOffence { get; set; }
    }

    public enum AddressType
    {
        Present = 0,
        Permanent = 1
    }

    public enum ProofType
    {
        AadharCard = 0,
        PanCard = 1,
        DrivingLicense = 2,
        BankPassBook = 3,
        VoterId = 4,
        ElectricityBill = 5,
        RationCard = 6,
        ESICCard = 7,
        Other = 8
    }


}
