using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ILogger<ManagementController> _logger;

        public ManagementController(ILogger<ManagementController> logger)
        {
            _logger = logger;
        }
        public IActionResult Management()
        {
            return View();
        }
    }
}
