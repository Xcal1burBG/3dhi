using _3dhi.Data;
using _3dhi.Data.Entities;
using _3dhi.Models.InputModels;
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


        // Create Message = Send Message
        public async Task<Message> CreateMessage(CreateMessageInputModel input)
        {
            var message = new Message
            {
                Id = Guid.NewGuid(),
                Date = DateTime.UtcNow,
                SenderId = Guid.NewGuid(), //this is going to be changed!
                ReceiverId = input.ReceiverId,
                Text = input.Text,

            };

            await this._db.Messages.AddAsync(message);
            await this._db.SaveChangesAsync();

            return message;
        }


        // Sending message from "Contact us" form sends list of messages to all users with role "Admin"
        public async Task SendMessageThroughContactUs(CreateMessageInputModel input)
        {
            var listOfAdmins = "";// TODO => service that returns list of the Ids of all admins

            foreach (var admin in listOfAdmins)
            {
                var message = new Message
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.UtcNow,
                    SenderId = Guid.NewGuid(), //this is going to be changed!
                    //ReceiverId = admin.Id,
                    Text = input.Text,

                };

                await this._db.Messages.AddAsync(message);

            }

            await this._db.SaveChangesAsync();

        }



        // Get Message
        // Get All messages
        public async Task<List<Message>> GetAllMessages()
        {
            var allMessages = await this._db.Messages.ToListAsync();
            return allMessages;
        }
    }
}
