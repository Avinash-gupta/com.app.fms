using BusinessEntities.Employee;
using DataAccessLayer;
using AutoMapper;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class EmployeeLogic
    {
        private readonly UnitOfWork _unitOfWork;

        public EmployeeLogic()
        {
            _unitOfWork = new UnitOfWork();
            Mapper.CreateMap<EmployeePersonalInfoEntity,EmployeePersonalInfo>();
            Mapper.CreateMap<EmployeePersonalInfo,EmployeePersonalInfoEntity>();
            Mapper.CreateMap<EmployeeInfoEntity, EmployeeInfo>();
            Mapper.CreateMap<EmployeeInfo, EmployeeInfoEntity>();
            Mapper.CreateMap<EmployeePhysicalStandardEntity, EmployeePhysicalStandard>();
            Mapper.CreateMap<EmployeePhysicalStandard, EmployeePhysicalStandardEntity>();
            Mapper.CreateMap<EmployeeAddressDetailsEntity, EmployeeAddressDetails>();
            Mapper.CreateMap<EmployeeAddressDetails, EmployeeAddressDetailsEntity>();
            Mapper.CreateMap<EmployeeBankDetailsEntity, EmployeeBankDetails>();
            Mapper.CreateMap<EmployeeBankDetails, EmployeeBankDetailsEntity>();
            Mapper.CreateMap<EmployeeSalaryDetailsEntity, EmployeeSalaryDetails>();
            Mapper.CreateMap<EmployeeSalaryDetails, EmployeeSalaryDetailsEntity>();
            Mapper.CreateMap<EmployeeProofsEntity, EmployeeProofs>();
            Mapper.CreateMap<EmployeeProofs, EmployeeProofsEntity>();
            Mapper.CreateMap<EmployeeExServiceEntity, EmployeeExService>();
            Mapper.CreateMap<EmployeeExService, EmployeeExServiceEntity>();
            Mapper.CreateMap<EmployeeFamilyDetailsEntity, EmployeeFamilyDetails>();
            Mapper.CreateMap<EmployeeFamilyDetails, EmployeeFamilyDetailsEntity>();
            Mapper.CreateMap<EmployeeEducationDetailsEntity,EmployeeEducationDetails>();
            Mapper.CreateMap<EmployeeEducationDetails, EmployeeEducationDetailsEntity>();
            Mapper.CreateMap<EmployeePreviousExperienceEntity, EmployeePreviousExperience>();
            Mapper.CreateMap<EmployeePreviousExperience, EmployeePreviousExperienceEntity>();
            Mapper.CreateMap<EmployeePolicyRecordEntity, EmployeePolicyRecord>();
            Mapper.CreateMap<EmployeePolicyRecord, EmployeePolicyRecordEntity>();
        }

        public void CreatNewEmployee(EmployeeEntity employeeEntity)
        {
            var employeeFamilyDetails = new List<EmployeeFamilyDetails>();
            var employeeEducationDetails = new List<EmployeeEducationDetails>();
            var employeePreviousExperienceDetails = new List<EmployeePreviousExperience>();
            try
            {
                var EmpId = _unitOfWork.EmployeePersonalInfoRepository.GetCount() + 1;
                var employeePersonalInfo = Mapper.Map<EmployeePersonalInfo>(employeeEntity.EmployeePersonalInfo);
                var employeeInfo = Mapper.Map<EmployeeInfo>(employeeEntity.EmployeeInfo);
                var employeePhysicalStandard = Mapper.Map<EmployeePhysicalStandard>(employeeEntity.EmployeePhysicalStandard);
                var employeeAddressDetails = Mapper.Map<EmployeeAddressDetails>(employeeEntity.EmployeeAddressDetails);
                var employeeBankDetails = Mapper.Map<EmployeeBankDetails>(employeeEntity.EmployeeBankDetails);
                var employeeSalaryDetails = Mapper.Map<EmployeeSalaryDetails>(employeeEntity.EmployeeSalaryDetails);
                var employeeProofs = Mapper.Map<EmployeeProofs>(employeeEntity.EmployeeProofs);
                var employeeExService = Mapper.Map<EmployeeExService>(employeeEntity.EmployeeExService);
                var employeePolicyRecord = Mapper.Map<EmployeePolicyRecord>(employeeEntity.EmployeePolicyRecord);

                foreach(var employeeFamilyDetail in employeeEntity.EmployeeFamilyDetails)
                {
                    var familyDetails = Mapper.Map<EmployeeFamilyDetails>(employeeFamilyDetail);
                    familyDetails.EmpId = EmpId;
                    employeeFamilyDetails.Add(familyDetails);
                }

                foreach (var employeeEducationDetail in employeeEntity.EmployeeEducationDetails)
                {
                    var educationDetails = Mapper.Map<EmployeeEducationDetails>(employeeEducationDetail);
                    educationDetails.EmpId = EmpId;
                    employeeEducationDetails.Add(educationDetails);
                }

                foreach (var employeePreviousExperience in employeeEntity.EmployeePreviousExperience)
                {
                    var experienceDetails = Mapper.Map<EmployeePreviousExperience>(employeePreviousExperience);
                    experienceDetails.EmpId = EmpId;
                    employeePreviousExperienceDetails.Add(experienceDetails);
                }

                if (employeePersonalInfo != null)
                {
                    employeePersonalInfo.IsActive = true;
                    employeePersonalInfo.EmpId = EmpId;
                    _unitOfWork.EmployeePersonalInfoRepository.Insert(employeePersonalInfo);
                }
                if (employeeInfo != null)
                {
                    employeeInfo.EmpId = EmpId;
                    _unitOfWork.EmployeeInfoRepository.Insert(employeeInfo);
                }
                if(employeePhysicalStandard != null)
                {
                    employeePhysicalStandard.EmpId = EmpId;
                    _unitOfWork.EmployeePhysicalStandardRepository.Insert(employeePhysicalStandard);
                }
                if(employeeAddressDetails != null)
                {
                    employeeAddressDetails.EmpId = EmpId;
                    _unitOfWork.EmployeeAddressDetailsRepository.Insert(employeeAddressDetails);
                }
                if(employeeBankDetails != null)
                {
                    employeeBankDetails.EmpId = EmpId;
                    _unitOfWork.EmployeeBankDetailsRepository.Insert(employeeBankDetails);
                }
                if(employeeSalaryDetails != null)
                {
                    employeeSalaryDetails.EmpId = EmpId;
                    _unitOfWork.EmployeeSalaryDetailsRepository.Insert(employeeSalaryDetails);
                }
                if(employeeProofs != null)
                {
                    employeeProofs.EmpId = EmpId;
                    _unitOfWork.EmployeeProofsRepository.Insert(employeeProofs);
                }
                if(employeeExService != null)
                {
                    employeeExService.EmpId = EmpId;
                    _unitOfWork.EmployeeExServiceRepository.Insert(employeeExService);
                }
                if(employeePolicyRecord != null)
                {
                    employeePolicyRecord.EmpId = EmpId;
                    _unitOfWork.EmployeePolicyRecordRepository.Insert(employeePolicyRecord);
                }

                foreach (var employeeFamilyDetail in employeeFamilyDetails)
                {
                    _unitOfWork.EmployeeFamilyDetailsRepository.Insert(employeeFamilyDetail);
                }
                foreach (var employeeEducationDetail in employeeEducationDetails)
                {
                    _unitOfWork.EmployeeEducationDetailsRepository.Insert(employeeEducationDetail);
                }
                foreach (var employeePreviousExperienceDetail in employeePreviousExperienceDetails)
                {
                    _unitOfWork.EmployeePreviousExperienceRepository.Insert(employeePreviousExperienceDetail);
                }

                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public EmployeeEntity GetEmployeeBy(int EmpId)
        {
            var employeeFamilyDetailsEntity = new List<EmployeeFamilyDetailsEntity>();
            var employeeEducationDetailsEntity = new List<EmployeeEducationDetailsEntity>();
            var employeePreviousExperienceEntity = new List<EmployeePreviousExperienceEntity>();
            try
            {
                var employeePersonalInfo = _unitOfWork.EmployeePersonalInfoRepository.GetSingle(e => e.EmpId == EmpId);
                var employeeAddressDetails = _unitOfWork.EmployeeAddressDetailsRepository.GetSingle(e => e.EmpId == EmpId);
                var employeeBankDetails = _unitOfWork.EmployeeBankDetailsRepository.GetSingle(e => e.EmpId == EmpId);
                var employeeEducationDetails = _unitOfWork.EmployeeEducationDetailsRepository.GetMany(e => e.EmpId == EmpId);
                var employeeExService = _unitOfWork.EmployeeExServiceRepository.GetSingle(e => e.EmpId == EmpId);
                var employeeFamilyDetails = _unitOfWork.EmployeeFamilyDetailsRepository.GetMany(e => e.EmpId == EmpId);
                var employeeInfo = _unitOfWork.EmployeeInfoRepository.GetSingle(e => e.EmpId == EmpId);
                var employeePhysicalStandard = _unitOfWork.EmployeePhysicalStandardRepository.GetSingle(e => e.EmpId == EmpId);
                var employeePolicyRecord = _unitOfWork.EmployeePolicyRecordRepository.GetSingle(e => e.EmpId == EmpId);
                var employeePreviousExperiences = _unitOfWork.EmployeePreviousExperienceRepository.GetMany(e => e.EmpId == EmpId);
                var employeeProofs = _unitOfWork.EmployeeProofsRepository.GetSingle(e => e.EmpId == EmpId);
                var employeeSalaryDetails = _unitOfWork.EmployeeSalaryDetailsRepository.GetSingle(e => e.EmpId == EmpId);

                var employeePersonalInfoEntity = Mapper.Map<EmployeePersonalInfoEntity>(employeePersonalInfo);
                var employeeAddressDetailsEntity = Mapper.Map<EmployeeAddressDetailsEntity>(employeeAddressDetails);
                var employeeBankDetailsEntity = Mapper.Map<EmployeeBankDetailsEntity>(employeeBankDetails);
                foreach(var employeeEducationDetail in employeeEducationDetails)
                {
                    employeeEducationDetailsEntity.Add(Mapper.Map<EmployeeEducationDetailsEntity>(employeeEducationDetail));
                }
                var employeeExServiceEntity = Mapper.Map<EmployeeExServiceEntity>(employeeExService);
                foreach (var employeeFamilyDetail in employeeFamilyDetails)
                {
                    employeeFamilyDetailsEntity.Add(Mapper.Map<EmployeeFamilyDetailsEntity>(employeeFamilyDetail));
                }
                var employeeInfoEntity = Mapper.Map<EmployeeInfoEntity>(employeeInfo);
                var employeePhysicalStandardEntity = Mapper.Map<EmployeePhysicalStandardEntity>(employeePhysicalStandard);
                var employeePolicyRecordEntity = Mapper.Map<EmployeePolicyRecordEntity>(employeePolicyRecord);
                foreach (var employeePreviousExperience in employeePreviousExperiences)
                {
                    employeePreviousExperienceEntity.Add(Mapper.Map<EmployeePreviousExperienceEntity>(employeePreviousExperience));
                }
                var employeeProofsEntity = Mapper.Map<EmployeeProofsEntity>(employeeProofs);
                var employeeSalaryDetailsEntity = Mapper.Map<EmployeeSalaryDetailsEntity>(employeeSalaryDetails);

                return new EmployeeEntity
                {
                    EmployeePersonalInfo = employeePersonalInfoEntity,
                    EmployeeAddressDetails = employeeAddressDetailsEntity,
                    EmployeeBankDetails = employeeBankDetailsEntity,
                    EmployeeEducationDetails = employeeEducationDetailsEntity,
                    EmployeeExService = employeeExServiceEntity,
                    EmployeeFamilyDetails = employeeFamilyDetailsEntity,
                    EmployeeInfo = employeeInfoEntity,
                    EmployeePhysicalStandard = employeePhysicalStandardEntity,
                    EmployeePolicyRecord = employeePolicyRecordEntity,
                    EmployeePreviousExperience = employeePreviousExperienceEntity,
                    EmployeeProofs = employeeProofsEntity,
                    EmployeeSalaryDetails = employeeSalaryDetailsEntity
                };

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EmployeeSearchResults> GetAllEmployees()
        {
            try
            {
                var employeePersonalInfoList = _unitOfWork.EmployeePersonalInfoRepository.GetMany(e => e.IsActive);
                IList<EmployeeSearchResults> searchResults = new List<EmployeeSearchResults>();
                foreach(var employee in employeePersonalInfoList)
                {
                    searchResults.Add(new EmployeeSearchResults {
                        EmpId = employee.EmpId,
                        EmployeeName = employee.LastName + " " + employee.FirstName,
                        Designation = employee.Designation,
                        DateOfJoining = employee.DateOfJoining,
                        SitePostedTo = employee.SitePostedTo,
                        Status = employee.Status
                    });
                }
                return searchResults;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEmployee(EmployeeEntity employeeEntity)
        {
            var employeeFamilyDetails = new List<EmployeeFamilyDetails>();
            var employeeEducationDetails = new List<EmployeeEducationDetails>();
            var employeePreviousExperienceDetails = new List<EmployeePreviousExperience>();
            var familyList = new List<EmployeeFamilyDetails>();
            var educationList = new List<EmployeeEducationDetails>();
            var expList = new List<EmployeePreviousExperience>();
            try
            {
                var employeePersonalInfo = Mapper.Map<EmployeePersonalInfo>(employeeEntity.EmployeePersonalInfo);
                var employeeInfo = Mapper.Map<EmployeeInfo>(employeeEntity.EmployeeInfo);
                var employeePhysicalStandard = Mapper.Map<EmployeePhysicalStandard>(employeeEntity.EmployeePhysicalStandard);
                var employeeAddressDetails = Mapper.Map<EmployeeAddressDetails>(employeeEntity.EmployeeAddressDetails);
                var employeeBankDetails = Mapper.Map<EmployeeBankDetails>(employeeEntity.EmployeeBankDetails);
                var employeeSalaryDetails = Mapper.Map<EmployeeSalaryDetails>(employeeEntity.EmployeeSalaryDetails);
                var employeeProofs = Mapper.Map<EmployeeProofs>(employeeEntity.EmployeeProofs);
                var employeeExService = Mapper.Map<EmployeeExService>(employeeEntity.EmployeeExService);
                var employeePolicyRecord = Mapper.Map<EmployeePolicyRecord>(employeeEntity.EmployeePolicyRecord);

                foreach (var employeeFamilyDetail in employeeEntity.EmployeeFamilyDetails)
                {
                    var familyDetails = Mapper.Map<EmployeeFamilyDetails>(employeeFamilyDetail);
                    familyDetails.EmpId = employeeEntity.EmployeePersonalInfo.EmpID;
                    employeeFamilyDetails.Add(familyDetails);
                }

                foreach (var employeeEducationDetail in employeeEntity.EmployeeEducationDetails)
                {
                    var educationDetails = Mapper.Map<EmployeeEducationDetails>(employeeEducationDetail);
                    educationDetails.EmpId = employeeEntity.EmployeePersonalInfo.EmpID;
                    employeeEducationDetails.Add(educationDetails);
                }

                foreach (var employeePreviousExperience in employeeEntity.EmployeePreviousExperience)
                {
                    var experienceDetails = Mapper.Map<EmployeePreviousExperience>(employeePreviousExperience);
                    experienceDetails.EmpId = employeeEntity.EmployeePersonalInfo.EmpID;
                    employeePreviousExperienceDetails.Add(experienceDetails);
                }
                if(employeePersonalInfo != null)
                {
                    _unitOfWork.EmployeePersonalInfoRepository.Update(employeePersonalInfo);
                }
                if(employeeInfo != null)
                {
                    employeeInfo.EmpId = employeePersonalInfo.EmpId;
                    _unitOfWork.EmployeeInfoRepository.Update(employeeInfo);
                }
                if(employeePhysicalStandard != null)
                {
                    employeePhysicalStandard.EmpId = employeePersonalInfo.EmpId; ;
                    _unitOfWork.EmployeePhysicalStandardRepository.Update(employeePhysicalStandard);
                }
                if(employeeAddressDetails != null)
                {
                    employeeAddressDetails.EmpId = employeePersonalInfo.EmpId;
                    _unitOfWork.EmployeeAddressDetailsRepository.Update(employeeAddressDetails);
                }
                if (employeeBankDetails != null)
                {
                    employeeBankDetails.EmpId = employeePersonalInfo.EmpId;
                    _unitOfWork.EmployeeBankDetailsRepository.Update(employeeBankDetails);
                }
                if(employeeSalaryDetails != null)
                {
                    employeeSalaryDetails.EmpId = employeePersonalInfo.EmpId;
                    _unitOfWork.EmployeeSalaryDetailsRepository.Update(employeeSalaryDetails);
                }
                if(employeeProofs != null)
                {
                    employeeProofs.EmpId = employeePersonalInfo.EmpId;
                    _unitOfWork.EmployeeProofsRepository.Update(employeeProofs);
                }
                if(employeeExService != null)
                {
                    employeeExService.EmpId = employeePersonalInfo.EmpId;
                    _unitOfWork.EmployeeExServiceRepository.Update(employeeExService);
                }
                if(employeePolicyRecord != null)
                {
                    employeePolicyRecord.EmpId = employeePersonalInfo.EmpId;
                    _unitOfWork.EmployeePolicyRecordRepository.Update(employeePolicyRecord);
                }

                foreach (var employeeFamilyDetail in employeeFamilyDetails)
                {
                    if (employeeFamilyDetail.Id == 0)
                    {
                        _unitOfWork.EmployeeFamilyDetailsRepository.Insert(employeeFamilyDetail);
                    }
                    else
                    {
                        _unitOfWork.EmployeeFamilyDetailsRepository.Update(employeeFamilyDetail);
                    }
                }

                foreach (var employeeEducationDetail in employeeEducationDetails)
                {
                    if (employeeEducationDetail.Id == 0)
                    {
                        _unitOfWork.EmployeeEducationDetailsRepository.Insert(employeeEducationDetail);
                    }
                    else
                    {
                        _unitOfWork.EmployeeEducationDetailsRepository.Update(employeeEducationDetail);
                    }
                }

                foreach (var employeePreviousExperienceDetail in employeePreviousExperienceDetails)
                {
                    if (employeePreviousExperienceDetail.Id == 0)
                    {
                        _unitOfWork.EmployeePreviousExperienceRepository.Insert(employeePreviousExperienceDetail);
                    }
                    else
                    {
                        _unitOfWork.EmployeePreviousExperienceRepository.Update(employeePreviousExperienceDetail);
                    }
                }
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEmployee(int EmpId)
        {
            try
            {
                var employee = _unitOfWork.EmployeePersonalInfoRepository.GetSingle(e => e.EmpId == EmpId);
                employee.IsActive = false;
                _unitOfWork.EmployeePersonalInfoRepository.Update(employee);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
