using System.ComponentModel.DataAnnotations;

namespace MyContact.Business.Entities
{
    public class MyNumber : BaseEntity
    {
        public int NumberId { get; set; }
        public int ContactId { get; set; }
        public string PhoneNumber { get; set; }
    }
}