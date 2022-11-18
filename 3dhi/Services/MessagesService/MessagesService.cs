using _3dhi.Data;
using _3dhi.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<Message>> GetAllMessages()
        {
            var allMessages = await this._db.Messages.ToListAsync();
            return allMessages;
        }
    }
}
