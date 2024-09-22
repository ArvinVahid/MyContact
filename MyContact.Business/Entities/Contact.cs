using System.ComponentModel.DataAnnotations;

namespace MyContact.Business.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public List<Number> Numbers { get; set; } = new List<Number>();
        public User User { get; set; }
    }
}