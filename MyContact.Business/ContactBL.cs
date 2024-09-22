using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business
{
    public class ContactBL : BaseBL<Contact, IContactRepo>
    {
        public ContactBL(IContactRepo contactRepo) : base(contactRepo)
        {
            
        }


    }
}
