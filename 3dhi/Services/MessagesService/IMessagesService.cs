using _3dhi.Data.Entities;

namespace _3dhi.Services.MessagesService
{
    public interface IMessagesService
    {
        public Task<List<Message>> GetAllMessages();
    }
}
