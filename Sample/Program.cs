using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeEntity
            {
                EmployeeAddressDetails = new EmployeeAddressDetailsEntity(),
                EmployeeEducationDetails = new List<EmployeeEducationDetailsEntity>
                {
                    new EmployeeEducationDetailsEntity()
                },
                EmployeeBankDetails = new EmployeeBankDetailsEntity(),
                EmployeeExService = new EmployeeExServiceEntity(),
                EmployeeFamilyDetails = new List<EmployeeFamilyDetailsEntity>
                {
                    new EmployeeFamilyDetailsEntity()
                },
                EmployeeInfo = new EmployeeInfoEntity(),
                EmployeePersonalInfo = new EmployeePersonalInfoEntity(),
                EmployeePhysicalStandard = new EmployeePhysicalStandardEntity(),
                EmployeePolicyRecord = new EmployeePolicyRecordEntity(),
                EmployeePreviousExperience = new List<EmployeePreviousExperienceEntity>
                {
                    new EmployeePreviousExperienceEntity()
                },
                EmployeeProofs = new EmployeeProofsEntity(),
                EmployeeSalaryDetails = new EmployeeSalaryDetailsEntity()
            };
            var json = new JavaScriptSerializer().Serialize(employee);
            Console.WriteLine(json);
        }
    }
}
