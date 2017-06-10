using System;


namespace BusinessEntities.Attendance
{
    public class AttendanceEntity
    {
        public int Id { get; set; }
        public string ContractId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool Attended { get; set; }
        public int NoOfHours { get; set; }
        public string Remarks { get; set; }
        public bool IsSubmitted { get; set; }
    }
}
