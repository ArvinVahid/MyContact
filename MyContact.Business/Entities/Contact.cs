using System.ComponentModel.DataAnnotations;

namespace MyContact.Business.Entities
{
    public class Contact : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<MyNumber> Numbers { get; set; } = new List<MyNumber>();
        public User User { get; set; }
    }
}