using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ContractBilling
    {
        public int Id { get; set; }
        [Required]
        public string ContractId { get; set; }
        public int MaterialCostForMonth { get; set; }
        public int MachineryCostForMonth { get; set; }
        public int ServiceCharge { get; set; }
        public string ContractDescription { get; set; }
        public string ServiceTax { get; set; }
        public string InvoiceDescription { get; set; }
        public bool _75PercentOfSTByClient { get; set; }
        public bool OneSixthReliverCharges { get; set; }
        public bool PDFS { get; set; }
    }
}
