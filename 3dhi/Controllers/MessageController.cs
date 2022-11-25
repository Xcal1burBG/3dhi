using _3dhi.Models.DTOs;
using _3dhi.Models.InputModels;
using _3dhi.Models.ViewModels;
using _3dhi.Services.MessagesService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class MessageController : Controller
    {
        private readonly ILogger<ManagementController> _logger;
        private readonly IMessagesService _messageService;
        private readonly IMapper _mapper;

        public MessageController(ILogger<ManagementController> logger, IMessagesService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }
        
        // SENDING MESSAGE FROM THE CONTACTS (CONTACT US) USES THE MESSAGE SENDING SYSTEM WITH 2 DIFFERENCES: 
        // 1. THE RECEIVER IS ALWAYS THE ADMIN
        // 2. THE SENDER DOESN'T HAVE TO BE LOGGED

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageInputModel input)
        {
            if(!this.ModelState.IsValid)
            {
                return this.View();
            }

            var message = await this._messageService.CreateMessage(input);
            var viewModel = this._mapper.Map<CreateMessageInputModel>(message);

            return View(viewModel);


        }
        [HttpPost]
        public async Task<IActionResult> SendMessageThroughContactUs(CreateMessageInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var message = await this._messageService.CreateMessage(input);
            var viewModel = this._mapper.Map<CreateMessageInputModel>(message);

            return View(viewModel);


        }

        public async Task<IActionResult> GetAllMessages()
        {
            var allMessages = await this._messageService.GetAllMessages();
            var viewModel = this._mapper.Map<MessagesDTO>(allMessages);
            return View(viewModel);
        }
    }
}
