using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeePolicyRecord
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
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
}
