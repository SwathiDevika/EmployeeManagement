using EmployeeManagement.BAL.Interface;
using EmployeeManagement.Data;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{
    public class EmployeeManagementController : ApiController
    {
        private IEmployeeManagementService _employeManagementService;
        public EmployeeManagementController(IEmployeeManagementService employeeManagementService)
        {
            _employeManagementService = employeeManagementService;
        }
        // GET: api/EmployeeManagement
        public IHttpActionResult GetAll()
        {
          return Ok(_employeManagementService.GetAll());
        }

       

        // POST: api/EmployeeManagement
        public IHttpActionResult Save([FromBody]PersonalDetail personDetail)
        {
            _employeManagementService.Save(personDetail);
            return Ok();
        }

        
    }
}
