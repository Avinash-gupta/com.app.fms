using BusinessEntities.Employee;
using DataAccessLayer;
using AutoMapper;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class EmployeeLogic
    {
        private readonly UnitOfWork _unitOfWork;

        public EmployeeLogic()
        {
            _unitOfWork = new UnitOfWork();
            Mapper.CreateMap<EmployeePersonlInfoEntity, EmployeePersonalInfo>();
            Mapper.CreateMap<EmployeePersonalInfo, EmployeePersonlInfoEntity>();
        }
        public void CreatNewEmployee(EmployeePersonlInfoEntity employeePersonalInfoEntity)
        {
            try
            {
                var employeePersonalInfo = Mapper.Map<EmployeePersonalInfo>(employeePersonalInfoEntity);
                employeePersonalInfo.CreatedDateTime = DateTime.Now;
                employeePersonalInfo.UpdatedDateTime = DateTime.Now;
                _unitOfWork.EmployeePersonalInfoRepository.Insert(employeePersonalInfo);
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {

            }
        }

        public EmployeePersonlInfoEntity GetEmployeeBy(string EmpId)
        {
            try
            {
                var employeePersonalInfo = _unitOfWork.EmployeePersonalInfoRepository.GetSingle(e => e.EmpID == EmpId);
                return Mapper.Map<EmployeePersonlInfoEntity>(employeePersonalInfo);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public IList<EmployeeSearchResults> GetAllEmployees()
        {
            try
            {
                IList<EmployeePersonalInfo> employeePersonalInfoList = _unitOfWork.EmployeePersonalInfoRepository.GetAll();
                IList<EmployeeSearchResults> searchResults = new List<EmployeeSearchResults>();
                foreach(var employee in employeePersonalInfoList)
                {
                    searchResults.Add(new EmployeeSearchResults {
                        EmpId = employee.EmpID,
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
                return null;
            }
        }

        public void UpdateEmployee(EmployeePersonlInfoEntity employeePersonalInofEntity)
        {
            try
            {
                var employeePersonalInfo = Mapper.Map<EmployeePersonalInfo>(employeePersonalInofEntity);
                employeePersonalInfo.UpdatedDateTime = DateTime.Now;
                _unitOfWork.EmployeePersonalInfoRepository.Update(employeePersonalInfo);
                _unitOfWork.Save();
            }
            catch(Exception e)
            {

            }
        }

        public void DeleteEmployee(string EmpId)
        {
            try
            {
                
                _unitOfWork.EmployeePersonalInfoRepository.Delete(EmpId);
                _unitOfWork.Save();
            }
            catch (Exception e)
            {

            }
        }
    }
}
