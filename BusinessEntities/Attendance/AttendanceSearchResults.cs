using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Attendance
{
    public class AttendanceSearchResults
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AttendaceDate { get; set; }
        public bool Attended { get; set; }
    }
}
