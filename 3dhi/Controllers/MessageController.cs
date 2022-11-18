using _3dhi.Models.DTOs;
using _3dhi.Models.ViewModels;
using _3dhi.Services.MessagesService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class MessageController : Controller
    {
        private readonly ILogger<ManagementController> _logger;
        private readonly MessagesService _messageService;
        private readonly IMapper _mapper;

        public MessageController(ILogger<ManagementController> logger, MessagesService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }
        public async Task<IActionResult> GetAllMessages()
        {
            var allMessages = await this._messageService.GetAllMessages();
            var viewModel = this._mapper.Map<MessagesDTO>(allMessages);
            return View(viewModel);
        }
    }
}
