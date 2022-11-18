using _3dhi.Data.Entities;
using _3dhi.Models.InputModels;

namespace _3dhi.Services.MessagesService
{
    public interface IMessagesService
    {
        public Task<Message> CreateMessage(CreateMessageInputModel input);
        public Task SendMessageThroughContactUs(CreateMessageInputModel input);
        public Task<List<Message>> GetAllMessages();
    }
}
