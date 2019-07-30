using EmployeeManage.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Data.Service
{
    public interface IEmployeeService
    {  
        List<User> GetUser();
        User GetUser(int id);
    }
}