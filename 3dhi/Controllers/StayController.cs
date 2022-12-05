using _3dhi.Services.StayService;
using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class StayController : Controller
    {
        private readonly ILogger<StayController> _logger;
        private readonly IStayService _stayService;

        public StayController(ILogger<StayController> logger)
        {
            _logger = logger;
        }

        [Route("~/stay")]
        public IActionResult Stay()
        {
            return View();
        }

        //[Httpost]
    }
}
