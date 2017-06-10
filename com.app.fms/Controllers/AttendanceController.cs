using BusinessEntities;
using BusinessEntities.Attendance;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace com.app.fms.Controllers
{
    [EnableCors("*",       // Origin
              "*", // Request headers
              "*"                        // HTTP methods
    )]
    public class AttendanceController : ApiController
    {
        private AttendanceLogic _attendanceLogic;
        public AttendanceController()
        {
            _attendanceLogic = new AttendanceLogic();
        }

        [ActionName("SaveAttendance")]
        // POST: api/Attendance/Entry
        public void SaveAttendance([FromBody]List<AttendanceEntity> attendanceList)
        {
            _attendanceLogic.SaveAttendance(attendanceList);
        }


        [ActionName("SubmitAttendance")]
        // POST: api/Attendance/Entry
        public void SubmitAttendance([FromBody]List<AttendanceEntity> attendanceList)
        {
            _attendanceLogic.SubmitAttendance(attendanceList);
        }

        [ActionName("GetAttendanceDetailsByDate")]
        // GET: api/Attendance/GetByDates
        public List<AttendanceEntity> GetAttendanceDetailsByDate([FromUri]int id, [FromUri] string date)
        {
            var Date = Convert.ToDateTime(date);
            return _attendanceLogic.GetAttendanceDetailsByDate(id, Date);
        }
    }
}