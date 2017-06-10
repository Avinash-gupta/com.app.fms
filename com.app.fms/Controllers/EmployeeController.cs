using BusinessEntities;
using BusinessEntities.Employee;
using BusinessLogic;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace com.app.fms.Controllers
{
    [EnableCors("*",       // Origin
              "*", // Request headers
              "*"                        // HTTP methods
    )]
    public class EmployeeController : ApiController
    {
        private EmployeeLogic _employeeLogic;

        public EmployeeController()
        {
            _employeeLogic = new EmployeeLogic();
        }

        //GET: api/Employee/GetById? EmplId = 1234
       [ActionName("GetBy")]
        public EmployeeEntity GetBy(int EmpId)
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
        public void Create([FromBody]EmployeeEntity employeePersonalInfoEntity)
        {
            _employeeLogic.CreatNewEmployee(employeePersonalInfoEntity);
        }

        [ActionName("Update")]
        //POST:api/Employee/Update
        public void Update([FromBody]EmployeeEntity employeePersonalInfoEntity)
        {
            _employeeLogic.UpdateEmployee(employeePersonalInfoEntity);
        }

        [HttpGet]
        [ActionName("Delete")]
        // DELETE: api/Employee/Delete?EmpId=1234
        public void Delete(int EmpId)
        {
            _employeeLogic.DeleteEmployee(EmpId);
        }

        [ActionName("GetAllDesignations")]
        public List<DesignationsEntity> GetAllDesignations()
        {
            return _employeeLogic.GetAllDesignations();
        }

        [ActionName("GetEmployeeByDesignation")]
        public List<EmployeeSearchResults> GetEmployeeByDesignation(string designation)
        {
            return _employeeLogic.GetEmployeesByDesignation(designation);
        }


        [ActionName("GetEmployeesByContractId")]
        public List<EmployeeSearchResults> GetEmployeesByContractId(int id)
        {
            return _employeeLogic.GetEmployeesByContractId(id);
        }

    }
}
