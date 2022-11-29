using _3dhi.Models.InputModels;
using _3dhi.Models.ViewModels;
using _3dhi.Services.ContactsService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ILogger<ContactsController> _logger;
        private readonly IContactsService _contactsService;
        private readonly IMapper _mapper;

        public ContactsController(ILogger<ContactsController> logger, IContactsService contactsService, IMapper mapper)
        {
            _logger = logger;
            _contactsService = contactsService;
            _mapper = mapper;
        }

        [Route("~/contacts")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        [Route("~/contactus")]

        public async Task<IActionResult> CreateContactUsMessage(CreateContactUsInputModel input)
        {
            var contactUsMessage = await this._contactsService.CreateMessageThroughContactUs(input);
            var output = this._mapper.Map<ContactUsMessageViewModel>(contactUsMessage);
            return View(output);
        }
    }
}
