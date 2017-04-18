using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeePersonalInfo
    {
        public int Id { get; set; }
        [Required]
        public string EmpID { get; set; }
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        public string Status { get; set; }
        public string Qualification { get; set; }
        [Required]
        public string Designation { get; set; }
        public DateTime DateOfInterview { get; set; }
        public DateTime DateOfJoining { get; set; }
        [Required]
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
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public DateTime UpdatedDateTime { get; set; }
    }
}
