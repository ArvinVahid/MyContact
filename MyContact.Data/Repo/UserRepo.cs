using Microsoft.EntityFrameworkCore;
using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Data.Repo
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        public UserRepo(DataContext context) : base(context)
        {
        }

        public void GetItem(int userId)
        {
            Query.AsNoTracking().First(u => u.Id == userId);
        }

        public User GetUserById(int userId)
        {
            return Query.FirstOrDefault(u => u.Id == userId);
        }

        public bool IsUserExists(User user)
        {
           
            return Query.AsNoTracking().Any(u => u.Id == user.Id);
        }

        User IUserRepo.GetItem(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
