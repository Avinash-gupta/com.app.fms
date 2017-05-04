using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ContractHumanResourceNeeds
    {
        public int Id { get; set; }
        [Required]
        public string ContractId { get; set; }
        public string Designation { get; set; }
        public string Type { get; set; }
        public int DutyHrs { get; set; }
        public int Qty { get; set; }
        public int PR { get; set; }
        public string DT { get; set; }
        public int NoOfDays { get; set; }
        public string Summary { get; set; }
        public string Nots { get; set; }
        public bool RCApplicable { get; set; }
        public int Basic { get; set; }
        public int DA { get; set; }
        public int HRA { get; set; }
    }
}
