using System.ComponentModel.DataAnnotations;

namespace MyContact.Business.Entities
{
    public class Number
    {
        public int UserId { get; set; }
        public int ContactId { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}