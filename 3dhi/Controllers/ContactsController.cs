using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ILogger<ContactsController> _logger;

        public ContactsController(ILogger<ContactsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
