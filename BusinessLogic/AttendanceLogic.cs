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
    }
}
