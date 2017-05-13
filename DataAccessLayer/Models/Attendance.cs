﻿using System;

namespace DataAccessLayer.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public string ContractId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool Attended { get; set; }
        public int NoOfHours { get; set; }
    }
}