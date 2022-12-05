using _3dhi.Services.StayService;
using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class ListingsController : Controller
    {
        private readonly ILogger<ListingsController> _logger;
        
        public ListingsController(ILogger<ListingsController> logger)
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
