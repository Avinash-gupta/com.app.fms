using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ClientInformation
    {
        public int Id { get; set; }
        [Required]
        public string ClientId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Segment { get; set; }
        public string ContactPerson { get; set; }
        public string PersonDesignation { get; set; }
        public int PhoneNos { get; set; }
        public int LandLineNo { get; set; }
        public string EmailId { get; set; }
        public int FaxNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTim { get; set; }
    }
}
