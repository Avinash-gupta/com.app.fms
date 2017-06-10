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
            try
            {
                var attendanceList = new List<AttendanceEntity>();
                var employeeList = new List<EmployeeSearchResults>();
                var contractId = _unitOfWork.ContractInformationRepository.Get(c => c.Id == id).ContractId;
                var _employeeList = _unitOfWork.EmployeePersonalInfoRepository.GetManyQueryable(e => e.ContractId == contractId);
                foreach (var _employee in _employeeList)
                {
                    if (_employee.ContractId == contractId)
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
                }
                return attendanceList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
