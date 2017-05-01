using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeExService
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
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
}
