using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class EmployeeFamilyDetails
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Age { get; set; }
        public string RelationShip { get; set; }
        public string Occupation { get; set; }
        public bool PFNominee { get; set; }
        public bool ESiNominee { get; set; }
        public bool ResidingWithRelation { get; set; }
        public string PlaceOfResidence { get; set; }
    }
}
