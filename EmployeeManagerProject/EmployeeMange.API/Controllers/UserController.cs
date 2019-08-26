using EmployeeManage.DAO;
using EmployeeManage.Data.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace EmployeeMange.API.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private EmployeeContext db = new EmployeeContext();
        private EmployeeService employeeService = new EmployeeService();

        //[HttpGet]
        //public IEnumerable<User> GetUser()
        //{
        //    return new List<User>();
        //}

        [HttpGet]
        public IEnumerable<User> GetUser(string searchString, int page, int pageSize)
        {
            return employeeService.GetUser(searchString, page, pageSize);
        }
        [HttpGet]
        public IEnumerable<User> GetUserAll()
        {
            return employeeService.GetUserAll();
        }
        [HttpGet]
        [Route("viewdetail")]
        public User ViewDetail(int id)
        {
            return employeeService.ViewDetail(id);
        }
    }
}