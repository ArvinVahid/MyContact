using MyContact.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business.Services.Interfaces
{
    public interface IContactService
    {
        void Insert(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
        List<Contact> GetAll(Func<Contact, bool> predicate);
        Contact GetById(int id);
    }
}
