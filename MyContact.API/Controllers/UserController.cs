using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyContact.Business;
using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using MyContact.Business.Services.Interfaces;

namespace MyContact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Insert")]
        public IActionResult Insert(User user)
        {
            _userService.Insert(user);
            return Ok(user);
        }

        [HttpGet("Update")]
        public IActionResult Update(User user)
        {
            _userService.Update(user);
            return Ok(user);
        }

        [HttpGet("Delete")]
        public IActionResult Delete(User user)
        {
            _userService.Delete(user);
            return Ok(user);
        }

        [HttpGet("GetAll")]
        public List<User> GetAll(Func<User, bool> predicate)
        {
            return _userService.GetAll(predicate);
        }

        [HttpGet("ById")]
        public User GetUserById(int id)
        {
            return _userService.GetById(id);
        }
    }
}
