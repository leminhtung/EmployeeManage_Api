using EmployeeManage.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeManage.Data.Service
{
    public interface IEmployeeService
    {
        IEnumerable<User> GetUser(string searchString, int page, int pageSize);

        IEnumerable<User> GetUserAll();

        bool Login(string Adminid, string Password);

        long Insert(User entity);

        bool Delete(int id);

        bool Update(User entity);

        User ViewDetail(int id);

        Admin GetById(string adminID);

    }
}