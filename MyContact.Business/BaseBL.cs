using MyContact.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business
{
    public class BaseBL<TEntity, TRepo>
        where TEntity : class
        where TRepo : IBaseRepo<TEntity>
    {
        protected readonly TRepo _repo;
        public BaseBL(TRepo repo)
        {
            _repo = repo;
        }

        public void Delete(TEntity entity)
        {
            _repo.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _repo.GetAll();
        }

        public void Insert(TEntity entity)
        {
            _repo.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _repo.Update(entity);
        }
    }
}
