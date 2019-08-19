using System.Collections.Generic;
using EmployeeManage.DAO;
using EmployeeManage.DAO.DAO;

namespace EmployeeManage.Data.Service
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeContext db = new EmployeeContext();

        public IEnumerable<User> GetUser(string searchString, int page, int pageSize)
        {
            UserDao userdao = new UserDao();
            return userdao.GetUser(searchString, page, pageSize);
        }

        public bool Login(string Adminid, string Password)
        {
            UserDao userdao = new UserDao();
            return userdao.Login(Adminid, Password);
        }

        public Admin GetById(string adminID)
        {
            UserDao userDao = new UserDao();
            return userDao.GetById(adminID);
        }

        public long Insert(User entity)
        {
            var dao = new UserDao();
            return dao.Insert(entity);
        }

        public bool Delete(int id)
        {
            var dao = new UserDao();
            return dao.Delete(id);
        }

        public User ViewDetail(int id)
        {
            var dao = new UserDao();
            return dao.ViewDetail(id);
        }

        public bool Update(User entity)
        {
            var dao = new UserDao();
            return dao.Update(entity);
        }
    }
}