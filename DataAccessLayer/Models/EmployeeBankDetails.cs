using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeBankDetails
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
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
}
