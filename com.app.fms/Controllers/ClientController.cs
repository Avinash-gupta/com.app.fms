using BusinessEntities;
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
    public class ClientController : ApiController
    {
        private ClientLogic _clientLogic;
        public ClientController()
        {
            _clientLogic = new ClientLogic();
        }

        //GET: api/Employee/GetById? EmplId = 1234
        [ActionName("GetBy")]
        public ClientEntity GetBy(string clientId)
        {
            return _clientLogic.GetClientBy(clientId);
        }

        [ActionName("GetAll")]
        //GET : api/Employee/GetAll
        public IList<ClientSearchResults> GetAll()
        {
            return _clientLogic.GetClientSearchResults();
        }

        [ActionName("Create")]
        // POST: api/Employee/Create
        public void Create([FromBody]ClientEntity clientEntity)
        {
            _clientLogic.CreateNewClient(clientEntity);
        }

        [ActionName("Update")]
        //POST:api/Employee/Update
        public void Update([FromBody]ClientEntity clientEntity)
        {
            _clientLogic.UpdateClient(clientEntity);
        }

        [HttpGet]
        [ActionName("Delete")]
        // DELETE: api/Employee/Delete?EmpId=1234
        public void Delete(string clientId)
        {
            _clientLogic.DeleteClient(clientId);
        }
    }
}