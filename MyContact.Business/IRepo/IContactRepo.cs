using MyContact.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business.IRepo
{
    public interface IContactRepo : IBaseRepo<Contact>
    {
        void GetItem(int ContactId);
    }
}
