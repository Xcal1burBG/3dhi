using _3dhi.Controllers;
using _3dhi.Data;
using _3dhi.Data.Entities;
using _3dhi.Models.InputModels;

namespace _3dhi.Services.ContactsService
{
    public class ContactsService : IContactsService
    {
        private readonly ApplicationDbContext _db;
        public ContactsService(ApplicationDbContext db)
        {
            _db = db;
        }

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

    }
}
