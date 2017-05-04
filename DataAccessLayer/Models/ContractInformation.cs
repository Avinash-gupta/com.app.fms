using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ContractInformation
    {
        public int Id { get; set; }
        [Required]
        public string ContractId { get; set; }
        [Required]
        public string ClientId { get; set; }
        public string ContractIds { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BGAmount { get; set; }
        public string TypeOfWork { get; set; }
        public DateTime ValidityDate { get; set; }
        public string BillingDates { get; set; }
        public string Payment { get; set; }
        public string PaySheetDates { get; set; }
        public string Wages { get; set; }
        public bool IsActive { get; set; }
    }
}
