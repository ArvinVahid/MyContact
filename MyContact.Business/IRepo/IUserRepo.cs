using MyContact.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business.IRepo
{
    public interface IUserRepo : IBaseRepo<User>
    {
        User GetItem(int userId);
        bool IsUserExists(User user);
        User GetUserById(int userId);
    }
}
