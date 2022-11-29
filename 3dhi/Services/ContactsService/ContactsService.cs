using _3dhi.Controllers;
using _3dhi.Data;
using _3dhi.Data.Entities;
using _3dhi.Models.InputModels;
using System.Security.Cryptography.X509Certificates;

namespace _3dhi.Services.ContactsService
{
    public class ContactsService : IContactsService
    {
        private readonly ApplicationDbContext _db;
        public ContactsService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ContactUsFormMessage> CreateMessageThroughContactUs(CreateContactUsInputModel input)
        {

            var contactUsMessage = new ContactUsFormMessage
            {
                SenderName = input.SenderName,
                Email = input.Email,
                CreatedDate = DateTime.UtcNow,
                Message = input.Message,
                PhoneNumber = input.PhoneNumber,
                IsMessageRead = false

            };

            await this._db.SaveChangesAsync();
            return contactUsMessage;

        }

    }
}
