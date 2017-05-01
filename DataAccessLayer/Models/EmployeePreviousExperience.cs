using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeePreviousExperience
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
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
}
