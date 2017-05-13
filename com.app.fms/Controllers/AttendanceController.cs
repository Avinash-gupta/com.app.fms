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

        [ActionName("Entry")]
        // POST: api/Attendance/Entry
        public void Entry([FromBody]List<AttendanceEntity> attendanceList)
        {
            _attendanceLogic.AttendanceEntry(attendanceList);
        }

        [ActionName("GetByDates")]
        // GET: api/Attendance/GetByDates
        public List<AttendanceEntity> GetByDates([FromUri]string contractId, [FromUri] DateTime fromDate,[FromUri] DateTime toDate)
        {
            return _attendanceLogic.GetAttendanceDetails(contractId,fromDate,toDate);
        }
    }
}