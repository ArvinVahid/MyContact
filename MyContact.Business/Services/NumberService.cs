using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business.Services
{
    public class NumberService : BaseService<MyNumber, INumberRepo>
    {
        public NumberService(INumberRepo numberRepo) : base(numberRepo)
        {

        }
    }
}
