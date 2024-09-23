using MyContact.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business.Services.Interfaces
{
    public interface IUserService
    {
        void Insert(User user);
        void Update(User user);
        void Delete(User user);
        List<User> GetAll(Func<User, bool> predicate);
        User GetById(int id);
    }
}
