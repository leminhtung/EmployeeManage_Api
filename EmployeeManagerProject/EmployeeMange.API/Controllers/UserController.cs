using EmployeeManage.DAO;
using EmployeeManage.Data.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace EmployeeMange.API.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        EmployeeContext db = new EmployeeContext();
        private EmployeeService employeeService = new EmployeeService();

        public IEnumerable<User> Get()
        {
            return employeeService.GetUser();
        }

        public IEnumerable<User> GetAllPaging(string searchString, int page, int pageSize)
        {
            return employeeService.ListAllpaging(searchString, page, pageSize);
        }

        [HttpGet]
        [Route("viewdetail")]
        public User ViewDetail(int id)
        {
            return employeeService.ViewDetail(id);
        }
    }
}
