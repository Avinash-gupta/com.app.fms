using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities;
using DataAccessLayer.Models;
using DataAccessLayer;
using BusinessEntities.Attendance;
using BusinessEntities.Employee;

namespace BusinessLogic
{
    public class AttendanceLogic
    {
        private readonly UnitOfWork _unitOfWork;
        public AttendanceLogic()
        {
            _unitOfWork = new UnitOfWork();
            Mapper.CreateMap<AttendanceEntity, Attendance>();
            Mapper.CreateMap<Attendance, AttendanceEntity>();
        }

        public void SaveAttendance(List<AttendanceEntity> attendanceList)
        {
            var _attendanceList = new List<Attendance>();
            try
            {
                foreach (var attendance in attendanceList)
                {
                    var _attendance = Mapper.Map<Attendance>(attendance);
                    if (_attendance.Id == 0)
                    {
                        _unitOfWork.AttendanceRepository.Insert(_attendance);
                    }
                    else
                    {
                        _unitOfWork.AttendanceRepository.Update(_attendance);
                    }
                }

                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SubmitAttendance(List<AttendanceEntity> attendanceList)
        {
            var _attendanceList = new List<Attendance>();
            try
            {
                foreach (var attendance in attendanceList)
                {
                    attendance.IsSubmitted = true;
                    var _attendance = Mapper.Map<Attendance>(attendance);
                    if (_attendance.Id == 0)
                    {
                        _unitOfWork.AttendanceRepository.Insert(_attendance);
                    }
                    else
                    {
                        _unitOfWork.AttendanceRepository.Update(_attendance);
                    }
                }

                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AttendanceEntity> GetAttendanceDetailsByDate(int id,DateTime date)
        {
            string contractId;
            try
            {
                var attendanceList = new List<AttendanceEntity>();
                var employeeList = new List<EmployeeSearchResults>();
                using (var context = new FMSGlobalDbContext())
                {
                    contractId = (from c in context.ContractInformation
                                 where c.Id == id 
                                 select c.ContractId).First();
                }
                if (contractId != null)
                {
                    var _employeeList = _unitOfWork.EmployeePersonalInfoRepository.GetMany(e => e.ContractId == contractId);
                    foreach (var _employee in _employeeList)
                    {
                        var attendance = _unitOfWork.AttendanceRepository.Get(a => a.EmployeeId == _employee.Id && a.AttendanceDate == date);
                        attendanceList.Add(new AttendanceEntity
                        {
                            Id = (attendance == null) ? 0 : attendance.Id,
                            ContractId = contractId,
                            EmployeeId = _employee.Id,
                            EmployeeName = _employee.FirstName + ' ' + _employee.LastName,
                            Designation = _employee.Designation,
                            Attended = (attendance == null) ? false : attendance.Attended,
                            NoOfHours = (attendance == null) ? 0 : attendance.NoOfHours,
                            Remarks = (attendance == null) ? "" : attendance.Remarks,
                            AttendanceDate = date,
                            IsSubmitted = (attendance == null) ? false : attendance.IsSubmitted
                        });

                    }
                    return attendanceList;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
