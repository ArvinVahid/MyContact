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
    public class ContactRepo : BaseRepo<Contact>, IContactRepo
    {
        public void GetItem(int ContactId)
        {
            Query.AsNoTracking().First(c => c.Id == ContactId);
        }
    }
}
