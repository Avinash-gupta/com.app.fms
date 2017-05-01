using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeePhysicalStandard
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string HairColour { get; set; }
        public int ChestUnExpand { get; set; }
        public int ChestExpand { get; set; }
        public string EyeColour { get; set; }
    }
}
