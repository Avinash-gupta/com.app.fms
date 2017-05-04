using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ContractInvoiceHeadingText
    {
        public int Id { get; set; }
        [Required]
        public string ContractId { get; set; }
        public bool DescriptionVisible { get; set; }
        public string DescriptionValue { get; set; }
        public bool NoOfEmpsVisible { get; set; }
        public string NoOfEmpsValue { get; set; }
        public bool NoOfDutiesVisible { get; set; }
        public string NoOfDutiesValue { get; set; }
        public bool PayrateVisible { get; set; }
        public string PayrateValue { get; set; }
        public bool AmountVisible { get; set; }
        public string AmountValue { get; set; }
    }
}
