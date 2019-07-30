using EmployeeManage.DAO;
using EmployeeManage.Data.Service;
using System.Web.Http;
using System.Web.Http.Description;

namespace EmployeeMange.API.Controllers
{
    public class AdminController : ApiController
    {
        EmployeeContext db = new EmployeeContext();
        private EmployeeService employeeService = new EmployeeService();

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
    }
}
