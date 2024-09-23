using MyContact.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Business.Services
{
    public class BaseService<TEntity, TRepo>
        where TEntity : class
        where TRepo : IBaseRepo<TEntity>
    {
        protected readonly TRepo _repo;
        public BaseService(TRepo repo)
        {
            _repo = repo;
        }

        public void Delete(TEntity entity)
        {
            _repo.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            List<TEntity> e = new List<TEntity>();
            return e;
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
