using MyContact.Business;
using MyContact.Data.Repo;

namespace MyContact
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserBL userBL = new UserBL(new UserRepo());
            userBL.Insert(new Business.Entities.User
            {
                FirstName = "Arvin",
                LastName = "Vahidkia",
            });

            ContactBL contactBL = new ContactBL(new ContactRepo());
            contactBL.Insert(new Business.Entities.Contact
            {
                FirstName = "Mohammad",
                LastName = "Yami",
                UserId = 1
            });

            NumberBL numberBL = new NumberBL(new NumberRepo());
            numberBL.Insert(new Business.Entities.Number
            {
                UserId = 1,
                ContactId = 1,
                PhoneNumber = "09120912000"
            });

        }
    }
}
