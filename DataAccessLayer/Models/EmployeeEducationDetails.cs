using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeEducationDetails
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
        public string Qualification { get; set; }   
        public string Description { get; set; }
        public string NameAndAddressOfCollege { get; set; }
        public string Board { get; set; }
        public int YearOfStudy { get; set; }
        public string Result { get; set; }
        public float Percentage { get; set; }
    }

}
