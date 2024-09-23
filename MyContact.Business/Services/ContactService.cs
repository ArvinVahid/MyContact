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
    public class ContactService : BaseService<Contact, IContactRepo>, IContactService
    {
        public ContactService(IContactRepo contactRepo) : base(contactRepo)
        {

        }

        public List<Contact> GetAll(Func<Contact, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            return _repo.GetContactById(id);
        }
    }
}
