using EmployeeManage.DAO;
using EmployeeManage.Data.Service;
using EmployeeMange.API.Common;
using System;
using System.Web.Http;
using System.Web.Http.Description;

namespace EmployeeMange.API.Controllers
{
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        EmployeeContext db = new EmployeeContext();
        private EmployeeService employeeService = new EmployeeService();
        [Route("insert")]
        [HttpPost]
        public long Insert(User entity)
        {
            return employeeService.Insert(entity);
        }
        [HttpDelete]
        public bool Delete([FromUri]int id)
        {
            return employeeService.Delete(id);
        }

        public Admin GetById(string adminID)
        {
            return employeeService.GetById(adminID);
        }

        [HttpPut]
        public bool Update([FromBody]User entity)
        {
            return employeeService.Update(entity);
        }
        [HttpPost]
        public bool Login([FromBody] LoginViewModel model)
        {
           return employeeService.Login(model.AdminId, model.Password);
        }
    }

    public class LoginViewModel
    {
        public string AdminId { get; set; }

        public string Password { get; set; }
    }
}
