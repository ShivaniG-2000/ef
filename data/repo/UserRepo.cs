using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data.entities;
using data.repo;

namespace data.repo
{
   public class UserRepo: IUserRepo
    {
        private User_Model db;
        public UserRepo(User_Model db)
        {
            this.db = db;
        }

        public void AddUser(User customer)
        {
            db.Users.Add(customer);
            Save();
        }

        public void DeleteUser(int id)
        {
            var user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                Save();
            }
            else
                throw new ArgumentException("User is not found");
        }

        public User GetUserById(int id)
        {
            if (id > 0)
            {
                var user = db.Users.FirstOrDefault();
                if (user != null)
                    return user;
                else
                    return null;
            }
            else
            {
                throw new ArgumentException("Id cannot be less than 0");
            }
        }

        public IEnumerable<User> GetUser()
        {
            return db.Users.ToList();
        }

        public void UpdateUser(int id)
        {
            var user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.AddOrUpdate(user);
                Save();
            }
            else
                throw new ArgumentException("User is not found");

        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
