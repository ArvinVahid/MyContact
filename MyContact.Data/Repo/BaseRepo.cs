using Microsoft.EntityFrameworkCore;
using MyContact.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Data.Repo
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity>
        where TEntity : class
    {
        private readonly DataContext _context;
        public BaseRepo()
        {
            _context = new DataContext();
        }

        protected IQueryable<TEntity> Query => _context.Set<TEntity>();

        public void Insert(TEntity entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            Save();
        }
        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
            Save();
        }

        public List<TEntity> GetAll()
        {
            return Query.AsNoTracking().ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
