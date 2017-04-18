using BusinessEntities.Employee;
using BusinessLogic;
using System.Collections.Generic;
using System.Web.Http;

namespace com.app.fms.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeLogic _employeeLogic;

        public EmployeeController()
        {
            _employeeLogic = new EmployeeLogic();
        }

        // GET: api/Employee/GetById?EmplId=1234
        [ActionName("GetBy")]
        public EmployeePersonlInfoEntity GetBy(string EmpId)
        {
            return _employeeLogic.GetEmployeeBy(EmpId);
        }

        [ActionName("GetAll")]
        //GET : api/Employee/GetAll
        public IList<EmployeeSearchResults> GetAll()
        {
            return _employeeLogic.GetAllEmployees();
        }

        [ActionName("Create")]
        // POST: api/Employee/Create
        public void Create([FromBody]EmployeePersonlInfoEntity employeePersonalInfoEntity)
        {
            _employeeLogic.CreatNewEmployee(employeePersonalInfoEntity);
        }

        [ActionName("Update")]
        //POST:api/Employee/Update
        public void Update([FromBody]EmployeePersonlInfoEntity employeePersonalInfoEntity)
        {
            _employeeLogic.UpdateEmployee(employeePersonalInfoEntity);
        }

        [ActionName("Delete")]
        // DELETE: api/Employee/Delete?EmpId=1234
        public void Delete(string EmpId)
        {
            _employeeLogic.DeleteEmployee(EmpId);
        }

    }
}
