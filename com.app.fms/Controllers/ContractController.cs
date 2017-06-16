using BusinessEntities.Contract;
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
    public class ContractController : ApiController
    {
        private ContractLogic _contractLogic;

        public ContractController()
        {
            _contractLogic = new ContractLogic();
        }

        //GET: api/Employee/GetById? EmplId = 1234
        [ActionName("GetBy")]
        public ContractEntity GetBy(int Id)
        {
            return _contractLogic.GetContractBy(Id);
        }

        [ActionName("GetAll")]
        //GET : api/Employee/GetAll
        public IList<ContractSearchResults> GetAll()
        {
            return _contractLogic.GetAllContracts();
        }

        [ActionName("GetAll")]
        //GET : api/Employee/GetAll
        public IList<ContractSearchResults> GetContractsByClientId(string clientId)
        {
            return _contractLogic.GetAllContracts();
        }

        [ActionName("Create")]
        // POST: api/Employee/Create
        public void Create([FromBody]ContractEntity contractEntity)
        {
            _contractLogic.CreateContract(contractEntity);
        }

        [ActionName("Update")]
        //POST:api/Employee/Update
        public void Update([FromBody]ContractEntity contractEntity)
        {
            _contractLogic.UpdateContract(contractEntity);
        }

        [HttpGet]
        [ActionName("Delete")]
        // DELETE: api/Employee/Delete?EmpId=1234
        public void Delete(string contractId)
        {
            _contractLogic.DeleteContract(contractId);
        }
    }
}