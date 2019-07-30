using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using EmployeeManage.DAO;
using EmployeeManage.DAO.DAO;

namespace EmployeeManage.Data.Service
{
    public class EmployeeService //: IEmployeeService
    {
        private EmployeeContext db = new EmployeeContext();

        public List<User> GetUser()
        {
            var a = db.Users.ToList();
            return a;
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ListAllpaging(string searchString, int page, int pageSize)
        {
            UserDao userdao = new UserDao();
            return userdao.ListAllpaging(searchString, page, pageSize);

            //return userdao.ListAllpaging(searchString, page,pageSize);
        }
        //public bool Login(string Adminid, string Password)
        //{
        //    var dao = new UserDao();
        //    var user = dao.GetById();
        //    var adminSesion = new EmployeeManage.DAO.Admin();
        //    adminSesion.AdminId = user.;
        //    return dao.Login(Adminid, Password);
        //}
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