using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data.entities;

namespace data.repo
{
    interface IUserRepo
    {
        IEnumerable<User> GetUser();
        User GetUserById(int id);
        void AddUser(User customer);
        void UpdateUser(int id);
        void DeleteUser(int id);
        void Save();
    }
}
