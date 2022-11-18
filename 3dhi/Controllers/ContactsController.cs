using _3dhi.Services.MessagesService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ILogger<ContactsController> _logger;
        private readonly MessagesService _messageService;
        private readonly IMapper _mapper;

        public ContactsController(ILogger<ContactsController> logger, MessagesService messageService, IMapper mapper)
        {
            _logger = logger;
            _messageService = messageService;
            _mapper = mapper;
        }

        [Route("~/contacts")]
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
