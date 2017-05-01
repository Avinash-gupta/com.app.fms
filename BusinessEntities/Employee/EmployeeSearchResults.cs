using System;

namespace BusinessEntities.Employee
{
    public class EmployeeSearchResults
    {
        public int EmpId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; } 
        public string SitePostedTo { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Status { get; set; }

    }
}
