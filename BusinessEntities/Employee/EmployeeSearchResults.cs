using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Employee
{
    public class EmployeeSearchResults
    {
        public string EmpId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string SitePostedTo { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Status { get; set; }

    }
}
