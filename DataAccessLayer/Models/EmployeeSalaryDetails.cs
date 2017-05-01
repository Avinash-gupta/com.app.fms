using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeSalaryDetails
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
        public int AdditionalAmount { get; set; }
        public int FoodAllowance { get; set; }
        public string NoOfDays { get; set; }
        public int Basic { get; set; }
        public int DA { get; set; }
        public int HRA { get; set; }
        public int Conveyance { get; set; }
        public int CCA { get; set; }
        public int LA { get; set; }
        public int Gratuity { get; set; }
        public int Bonus { get; set; }
        public int WA { get; set; }
        public int OA { get; set; }
        public int NFHs  { get; set; }
        public int SplAllowance { get; set; }
        public int RC { get; set; }
        public int CS { get; set; }
        public int OTRate { get; set; }
        public string  Nots { get; set; }
        public int TravellingAllowance { get; set; }
        public int PerformanceAllowance { get; set; }
        public int MobileAllowance { get; set; }
        public int MedicalAllowance { get; set; }
        public bool PFDeduct { get; set; }
        public bool PTDeduct { get; set; }
        public int EPFNo { get; set; }
        public DateTime PFEnrollDate { get; set; }
        public bool ESIDeduct { get; set; }
        public int ESINo { get; set; }
        public string ESIDispName { get; set; }
    }
}
