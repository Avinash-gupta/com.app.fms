using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeAddressDetails
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
        public string TmpAddressLine1 { get; set; }
        public string TmpAddressLine2 { get; set; }
        public string TmpLandMark { get; set; }
        public string TmpPostOffice { get; set; }
        public string TmpPoliceStation { get; set; }
        public string TmpState { get; set; }
        public string TmpDistrict { get; set; }
        public string TmpPincode { get; set; }
        public string PerAddressLine1 { get; set; }
        public string PerAddressLine2 { get; set; }
        public string PerLandMark { get; set; }
        public string PerPostOffice { get; set; }
        public string PerState { get; set; }
        public string PerDistrict { get; set; }
        public string PerPincode { get; set; }
    }

    public enum AddressType
    {
        Present = 0,
        Permanent = 1
    }
}
