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
                employeePersonalInfo.CreatedDateTime = DateTime.Now;
                employeePersonalInfo.UpdatedDateTime = DateTime.Now;
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

                employeePersonalInfo.IsActive = true;
                employeePersonalInfo.EmpId = EmpId;
                employeeInfo.EmpId = EmpId;
                employeePhysicalStandard.EmpId = EmpId;
                employeeAddressDetails.EmpId = EmpId;
                employeeBankDetails.EmpId = EmpId;
                employeeSalaryDetails.EmpId = EmpId;
                employeeProofs.EmpId = EmpId;
                employeeExService.EmpId = EmpId;
                employeePolicyRecord.EmpId = EmpId;

                _unitOfWork.EmployeePersonalInfoRepository.Insert(employeePersonalInfo);
                _unitOfWork.EmployeeInfoRepository.Insert(employeeInfo);
                _unitOfWork.EmployeePhysicalStandardRepository.Insert(employeePhysicalStandard);
                _unitOfWork.EmployeeAddressDetailsRepository.Insert(employeeAddressDetails);
                _unitOfWork.EmployeeBankDetailsRepository.Insert(employeeBankDetails);
                _unitOfWork.EmployeeSalaryDetailsRepository.Insert(employeeSalaryDetails);
                _unitOfWork.EmployeeProofsRepository.Insert(employeeProofs);
                _unitOfWork.EmployeeExServiceRepository.Insert(employeeExService);
                foreach(var employeeFamilyDetail in employeeFamilyDetails)
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
                _unitOfWork.EmployeePolicyRecordRepository.Insert(employeePolicyRecord);

                _unitOfWork.Save();
            }
            catch(Exception ex)
            {

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
                return null;
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
                //var employeePersonalnfoEntityList = Mapper.Map<IList<EmployeePersonalInfo>, IList<Employee>>(employeePersonalInfoList);
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
            int Id = 0;
            try
            {
                using (var context = new FMSGlobalDbContext())
                {
                    var employeePersonalInfoList = context.EmployeePersonalInfo.ToList();
                    foreach(var employee in employeePersonalInfoList)
                    {
                        if (employee.EmpId == employeeEntity.EmployeePersonalInfo.EmpID)
                        {
                            Id = employee.Id;
                            break;
                        }
                    }
                }
                    //var Id = _unitOfWork.EmployeePersonalInfoRepository.GetFirst(e => e.EmpId == employeeEntity.EmployeePersonalInfo.EmpID).Id;
                    //var Id = 1;
                var employeePersonalInfo = Mapper.Map<EmployeePersonalInfo>(employeeEntity.EmployeePersonalInfo);
                employeePersonalInfo.UpdatedDateTime = DateTime.Now;
                var employeeInfo = Mapper.Map<EmployeeInfo>(employeeEntity.EmployeeInfo);
                var employeePhysicalStandard = Mapper.Map<EmployeePhysicalStandard>(employeeEntity.EmployeePhysicalStandard);
                var employeeAddressDetails = Mapper.Map<EmployeeAddressDetails>(employeeEntity.EmployeeAddressDetails);
                var employeeBankDetails = Mapper.Map<EmployeeBankDetails>(employeeEntity.EmployeeBankDetails);
                var employeeSalaryDetails = Mapper.Map<EmployeeSalaryDetails>(employeeEntity.EmployeeSalaryDetails);
                var employeeProofs = Mapper.Map<EmployeeProofs>(employeeEntity.EmployeeProofs);
                var employeeExService = Mapper.Map<EmployeeExService>(employeeEntity.EmployeeExService);
                var employeePolicyRecord = Mapper.Map<EmployeePolicyRecord>(employeeEntity.EmployeePolicyRecord);
                using (var context = new FMSGlobalDbContext())
                {
                    familyList = context.EmployeeFamilyDetails.ToList();
                    educationList = context.EmployeeEducationDetails.ToList();
                    expList = context.EmployeePreviousExperience.ToList();
                }

                foreach (var item in familyList)
                {
                    foreach (var employeeFamilyDetail in employeeEntity.EmployeeFamilyDetails)
                    {
                        var familyDetails = Mapper.Map<EmployeeFamilyDetails>(employeeFamilyDetail);
                        if (item.EmpId == employeeEntity.EmployeePersonalInfo.EmpID && familyDetails.Id == 0)
                        {
                            familyDetails.Id = item.Id;
                            familyDetails.EmpId = item.EmpId;
                        }
                        employeeFamilyDetails.Add(familyDetails);
                    }
                }

                foreach (var item in educationList)
                {
                    foreach (var employeeEducationDetail in employeeEntity.EmployeeEducationDetails)
                    {
                        var educationDetails = Mapper.Map<EmployeeEducationDetails>(employeeEducationDetail);
                        if (item.EmpId == employeeEntity.EmployeePersonalInfo.EmpID && educationDetails.Id == 0)
                        {
                            educationDetails.Id = item.Id;
                            educationDetails.EmpId = item.EmpId;
                            employeeEducationDetails.Add(educationDetails);
                            break;
                        }
                    }
                }

                foreach (var item in expList)
                {
                    foreach (var employeePreviousExperience in employeeEntity.EmployeePreviousExperience)
                    {
                        var experienceDetails = Mapper.Map<EmployeePreviousExperience>(employeePreviousExperience);
                        if (item.EmpId == employeeEntity.EmployeePersonalInfo.EmpID && experienceDetails.Id == 0)
                        {
                            experienceDetails.Id = item.Id;
                            experienceDetails.EmpId = item.EmpId;
                            employeePreviousExperienceDetails.Add(experienceDetails);
                            break;
                        }
                    }
                }

                employeePersonalInfo.Id = Id;
                employeeInfo.Id = Id;
                employeePhysicalStandard.Id = Id;
                employeeAddressDetails.Id = Id;
                employeeBankDetails.Id = Id;
                employeeSalaryDetails.Id = Id;
                employeeProofs.Id = Id;
                employeeExService.Id = Id;
                employeePolicyRecord.Id = Id;

                employeeInfo.EmpId = employeePersonalInfo.EmpId;
                employeePhysicalStandard.EmpId = employeePersonalInfo.EmpId;
                employeeAddressDetails.EmpId = employeePersonalInfo.EmpId;
                employeeBankDetails.EmpId = employeePersonalInfo.EmpId;
                employeeSalaryDetails.EmpId = employeePersonalInfo.EmpId;
                employeeProofs.EmpId = employeePersonalInfo.EmpId;
                employeeExService.EmpId = employeePersonalInfo.EmpId;
                employeePolicyRecord.EmpId = employeePersonalInfo.EmpId;

                _unitOfWork.EmployeePersonalInfoRepository.Update(employeePersonalInfo);
                _unitOfWork.EmployeeInfoRepository.Update(employeeInfo);
                _unitOfWork.EmployeePhysicalStandardRepository.Update(employeePhysicalStandard);
                _unitOfWork.EmployeeAddressDetailsRepository.Update(employeeAddressDetails);
                _unitOfWork.EmployeeBankDetailsRepository.Update(employeeBankDetails);
                _unitOfWork.EmployeeSalaryDetailsRepository.Update(employeeSalaryDetails);
                _unitOfWork.EmployeeProofsRepository.Update(employeeProofs);
                _unitOfWork.EmployeeExServiceRepository.Update(employeeExService);
                foreach (var employeeFamilyDetail in employeeFamilyDetails)
                {
                    if (employeeFamilyDetail.EmpId == 0)
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
                    if (employeeEducationDetail.EmpId == 0)
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
                    if (employeePreviousExperienceDetail.EmpId == 0)
                    {
                        _unitOfWork.EmployeePreviousExperienceRepository.Insert(employeePreviousExperienceDetail);
                    }
                    else
                    {
                        _unitOfWork.EmployeePreviousExperienceRepository.Update(employeePreviousExperienceDetail);
                    }
                }
                _unitOfWork.EmployeePolicyRecordRepository.Update(employeePolicyRecord);

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
