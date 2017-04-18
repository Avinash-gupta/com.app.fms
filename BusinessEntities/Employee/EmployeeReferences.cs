namespace BusinessEntities.Employee
{
    public class EmployeeReferencesEntity
    {
        public Employeeinfo EmployeeInfo { get; set; }
        public Physicalstandard PhysicalStandard { get; set; }
        public Addressdetails AddressDetails { get; set; }
    }

    public class Employeeinfo
    {
        public string RefNameAddress1 { get; set; }
        public string RefNameAddress2 { get; set; }
        public string BloodGroup { get; set; }
        public string Remarks { get; set; }
        public string PhysicalRemarks { get; set; }
        public string IdentificationMarks1 { get; set; }
        public string IdentificationMarks2 { get; set; }
        public string SpeciallyAbled { get; set; }
        public string ApplicantCategory { get; set; }
    }

    public class Physicalstandard
    {
        public int Height { get; set; }
        public int ChestunExpand { get; set; }
        public int Weight { get; set; }
        public int ChestExpand { get; set; }
        public string HairColour { get; set; }
        public string EyeColour { get; set; }
    }

    public class Addressdetails
    {
        public Presentaddress PresentAddress { get; set; }
        public Permanentaddress PermanentAddress { get; set; }
    }

    public class Presentaddress
    {
        public string LandMark { get; set; }
        public string VillageOrTown { get; set; }
        public string PostOffice { get; set; }
        public string Taluka { get; set; }
        public string PoliceStation { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public int PinCode { get; set; }
        public string DateSinceResiding { get; set; }
        public string PeriodOfStay { get; set; }
        public int Phone { get; set; }
    }

    public class Permanentaddress
    {
        public string LandMark { get; set; }
        public string VillageOrTown { get; set; }
        public string PostOffice { get; set; }
        public string Taluka { get; set; }
        public string PoliceStation { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public int PinCode { get; set; }
        public string DateSinceResiding { get; set; }
        public string PeriodOfStay { get; set; }
        public int Phone { get; set; }
    }
}
