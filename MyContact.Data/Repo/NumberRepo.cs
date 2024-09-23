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
    public class NumberRepo : BaseRepo<MyNumber>, INumberRepo
    {
        public NumberRepo(DataContext context) : base(context)
        {
        }

        public bool IsNumberExists(string mobileNumber)
        {
            return Query.AsNoTracking().Any(n => n.PhoneNumber == mobileNumber);
        }
    }
}
