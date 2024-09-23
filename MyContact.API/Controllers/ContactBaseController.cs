/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyContact.Business.IRepo;

namespace MyContact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ContactBaseController<TEntity, TRepo> : ControllerBase 
        where TEntity : class
        where TRepo : IBaseRepo<TEntity>
    {
        protected readonly TRepo _repo;
        public ContactBaseController(TRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("Delete")]
        public IActionResult Delete(TEntity entity)
        {
            _repo.Delete(entity);
            return Ok(entity);
        }

        [HttpGet("GetAll")]
        public List<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
           return _repo.GetAll(predicate);
        }

        [HttpGet("Insert")]
        public IActionResult Insert(TEntity entity)
        {
            _repo.Insert(entity);
            return Ok(entity);
        }

        [HttpGet("Update")]
        public IActionResult Update(TEntity entity)
        {
            _repo.Update(entity);
            return Ok(entity);
        }
    }
}
*/