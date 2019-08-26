using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManage.DAO.DAO
{
    public class UserDao
    {
        private EmployeeContext db = null;

        public UserDao()
        {
            db = new EmployeeContext();
        }
        public IEnumerable<User> GetUser(string searchString, int page, int pageSize)
        {
            IQueryable<User> model = db.Users; // lấy toàn bộ liên kết
            if (!string.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                model = model.Where(x => x.Username.Contains(searchString/*, comparer: new IEqualityComparer*/)); //lọc theo chuỗi tìm kiếm
            }
            return model.OrderByDescending(x => x.UserId).ToList(); //Chú Ý
        }


        public IEnumerable<User> GetUserAll()
        {
            IQueryable<User> model = db.Users; // lấy toàn bộ liên kết
            return model.OrderByDescending(x => x.UserId).ToList(); //Chú Ý
        }
        public Admin GetById(string adminID)
        {
            return db.Admins.SingleOrDefault(x => x.AdminId == adminID);
        }

        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }

        public bool Login(string Adminid, string Password)
        {
            var result = db.Admins.Count(x => x.AdminId == Adminid && x.Password == Password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.UserId;
        }

        public bool Delete(int id)
        {
            try
            {
                var rs = db.Users.SingleOrDefault(a => a.UserId.Equals(id));
                db.Users.Remove(rs);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.UserId);
                user.Username = entity.Username;
                user.PhoneNumber = entity.PhoneNumber;
                user.Email = entity.Email;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}