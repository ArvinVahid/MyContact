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
        public void GetItem(int userId)
        {
            Query.AsNoTracking().First(u => u.Id == userId);
        }
    }
}
