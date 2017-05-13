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

        public void AttendanceEntry(List<AttendanceEntity> attendanceList)
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

        public List<AttendanceEntity> GetAttendanceDetails(string contractId,DateTime fromDate,DateTime toDate)
        {
            try
            {
                var attendanceList = new List<AttendanceEntity>();
                var context = new FMSGlobalDbContext();
                var _attendaceList = from a in context.Attendance
                                     where a.ContractId == contractId &&
                                     (a.AttendanceDate >= fromDate && a.AttendanceDate <= toDate)
                                     select a;
                foreach (var _attendace in _attendaceList)
                {
                    attendanceList.Add(Mapper.Map<AttendanceEntity>(_attendace));
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
