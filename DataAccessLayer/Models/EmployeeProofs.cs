using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeProofs
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
        public string AadharCardNumber { get; set; }
        public string AadharCardName { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string DrivingLicenseName { get; set; }
        public string VoterIDNumber { get; set; }
        public string VoterIDName { get; set; }
        public string RationCardNumber { get; set; }
        public string RationCardName { get; set; }
        public string PancardNumber { get; set; }
        public string PancardName { get; set; }
        public string BankPassBookNumber { get; set; }
        public string BankPassBookName { get; set; }
        public string ElectricityBillNumber { get; set; }
        public string ElectricityBillName { get; set; }
        public string EsicCardNumber { get; set; }
        public string EsicCardName { get; set; }
        public string ExServiceNumber { get; set; }
        public bool EMPExService { get; set; }
        public string ExServicedateOfEnrollment { get; set; }
        public string ExServiceRank { get; set; }
        public string ExServiceCrops { get; set; }
        public string ExServicemedicalCategory { get; set; }
        public string ExServiceconduct { get; set; }
        public string ExServiceTrade { get; set; }
        public string ExServicedateOfDischarge { get; set; }
        public string OtherCardsNumber { get; set; }
        public string OtherCardsName { get; set; }
    }

    public enum ProofType
    {
        AadharCard = 0,
        PanCard = 1,
        DrivingLicense = 2,
        BankPassBook = 3,
        VoterId = 4,
        ElectricityBill = 5,
        RationCard = 6,
        ESICCard = 7,
        Other = 8
    }
}
