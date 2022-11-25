using _3dhi.Models.InputModels;

namespace _3dhi.Services.ContactsService
{
    public interface IContactsService
    {
        public Task SendMessageThroughContactUs(CreateMessageInputModel input);
    }
}
