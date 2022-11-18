using _3dhi.Data;
using _3dhi.Data.Entities;

namespace _3dhi.Services.MessagesService
{
    public class MessagesService : IMessagesService
    {

        private readonly ApplicationDbContext _db;
        public MessagesService(ApplicationDbContext db)
        {
            _db = db;
        }
        // Send Message
        // Get Message
        // Get All messages
        public async Task<Message> GetAllMessages()
        {
            var allMessages = 
        }
    }
}
