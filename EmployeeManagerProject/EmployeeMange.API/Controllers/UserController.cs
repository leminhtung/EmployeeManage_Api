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

        //[HttpGet]
        //public IEnumerable<User> GetUser()
        //{
        //    return new List<User>();
        //}

        [HttpGet]
        public IEnumerable<User> GetUser()
        {
            return employeeService.GetUser();
        }
        //public IEnumerable<User> GetAllPaging(string searchString, int page = 1, int pageSize = 10)
        //{
        //    return employeeService.ListAllpaging(searchString, page, pageSize);
        //}

        [HttpGet]
        [Route("viewdetail")]
        public User ViewDetail(int id)
        {
            return employeeService.ViewDetail(id);
        }
    }
}
