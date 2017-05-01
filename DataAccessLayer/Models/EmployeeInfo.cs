using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeInfo
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
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
}
