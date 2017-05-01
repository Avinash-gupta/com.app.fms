namespace BusinessEntities.Employees
{
    public class EmployeeBANK_PF_ESIEntity
    {
        public Bankdetails BankDetails { get; set; }
        public Pfdetails PFDetails { get; set; }
        public Esidetails ESIDetails { get; set; }
        public Salarydetails SalaryDetails { get; set; }
        public Salarystructure SalaryStructure { get; set; }
    }

    public class Bankdetails
    {
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string bankAppNo { get; set; }
        public string InsuranceNominee { get; set; }
        public string NomineeDateOfBirth { get; set; }
        public string InsuranceCover { get; set; }
        public int BankAccNo { get; set; }
        public string IFSCCode { get; set; }
        public string BankCodeNo { get; set; }
        public string RegionCode { get; set; }
        public string BankCardReference { get; set; }
        public string NomineeRelation { get; set; }
        public string InsDebtAmount { get; set; }
        public string UANNo { get; set; }
    }

    public class Pfdetails
    {
        public string PFDeduct { get; set; }
        public string PTDeduct { get; set; }
        public int EPFNo { get; set; }
        public string PFEnrollDate { get; set; }
    }

    public class Esidetails
    {
        public string ESIDeduct { get; set; }
        public int ESINo { get; set; }
        public string ESIDispName { get; set; }
    }

    public class Salarydetails
    {
        public int AdditionalAmount { get; set; }
        public int FoodAllowance { get; set; }
    }

    public class Salarystructure
    {
        public int NoOfDays { get; set; }
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
    }
}
