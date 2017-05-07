using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Contract
{
    public class ContractSearchResults
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public string ContractId { get; set; }
        public string ContractStartDate { get; set; }
        public string ContractEndDate { get; set; }
    }
}
