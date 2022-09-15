using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class StayController : Controller
    {
        private readonly ILogger<StayController> _logger;

        public StayController(ILogger<StayController> logger)
        {
            _logger = logger;
        }
        public IActionResult Stay()
        {
            return View();
        }
    }
}
