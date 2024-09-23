using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using MyContact.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business.Services
{
    public class UserService : BaseService<User, IUserRepo>, IUserService
    {
        public UserService(IUserRepo userRepo) : base(userRepo)
        {
        }
        public List<User> g(int id)
        {
            return _repo.GetAll(p => p.Id == id);
        }

        public List<User> GetAll(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _repo.GetUserById(id);
        }
    }
}
