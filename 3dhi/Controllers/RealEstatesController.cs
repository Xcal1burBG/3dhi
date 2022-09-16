using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class RealEstatesController : Controller
    {
        private readonly ILogger<RealEstatesController> _logger;

        public RealEstatesController(ILogger<RealEstatesController> logger)
        {
            _logger = logger;
        }

        [Route("~/realestates")]
        public IActionResult RealEstates()
        {
            return View();
        }
    }
}
