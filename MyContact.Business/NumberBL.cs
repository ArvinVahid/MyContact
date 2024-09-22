using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business
{
    public class NumberBL : BaseBL<Number, INumberRepo>
    {
        public NumberBL(INumberRepo numberRepo) : base(numberRepo)
        {
            
        }
    }
}
