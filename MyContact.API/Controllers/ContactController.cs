using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using MyContact.Business.Services;
using MyContact.Business.Services.Interfaces;

namespace MyContact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("Insert")]
        public IActionResult Insert(Contact contact)
        {
            _contactService.Insert(contact);
            return Ok(contact);
        }

        [HttpGet("Update")]
        public IActionResult Update(Contact contact)
        {
            _contactService.Update(contact);
            return Ok(contact);
        }

        [HttpGet("Delete")]
        public IActionResult Delete(Contact contact)
        {
            _contactService.Delete(contact);
            return Ok(contact);
        }

        [HttpGet("GetAll")]
        public List<Contact> GetAll(Func<Contact, bool> predicate)
        {
            return _contactService.GetAll(predicate);
        }

        [HttpGet("ById")]
        public Contact GetContactById(int id)
        {
            return _contactService.GetById(id);
        }
    }
}
