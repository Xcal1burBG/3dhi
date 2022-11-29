using _3dhi.Data.Entities;
using _3dhi.Models.InputModels;

namespace _3dhi.Services.ContactsService
{
    public interface IContactsService
    {
        public Task<ContactUsFormMessage> CreateMessageThroughContactUs(CreateContactUsInputModel input);
    }
}
