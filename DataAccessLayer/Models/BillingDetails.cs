using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class BillingDetails
    {
        public int Id { get; set; }
        [Required]
        public string ClientId { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string LineFour { get; set; }
        public string LineFive { get; set; }
        public string LineSix { get; set; }
        public string Description { get; set; }
        public string SubUnit { get; set; }
        public string MainUnit { get; set; }
        public string Invoice { get; set; }
        public string PaySheet { get; set; }
        public string Location { get; set; }
    }
}
