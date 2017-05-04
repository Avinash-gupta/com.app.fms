using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ContractPaysheet
    {
        public int Id { get; set; }
        [Required]
        public string ContractId { get; set; }
        public int PFPercentage { get; set; }
        public string PFPercentageOf { get; set; }
        public string PFPercentageOn { get; set; }
        public int ESIPercentage { get; set; }
        public string ESIPercentageOf { get; set; }
        public string ESIPercentageOn { get; set; }
        public int PFLimitValue { get; set; }
        public bool PFLimit { get; set; }
        public int ESILimitValue { get; set; }
        public bool ESILimit { get; set; }
        public int OTPercentage { get; set; }
        public string OTAmount { get; set; }
        public bool OJT { get; set; }
        public bool PL { get; set; }
        public int PLValue { get; set; }
        public int OWF { get; set; }
        public int Tds { get; set; }
        public string TDSOn { get; set; }
        public int PONO { get; set; }
        public DateTime ExpectedDateOfReceipt { get; set; }
        public string ESIBranch { get; set; }
    }
}
