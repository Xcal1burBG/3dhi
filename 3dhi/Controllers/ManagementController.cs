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

        [Route("~/management")]
        public IActionResult Management()
        {
            return View();
        }


        // Manage Listings

        [HttpPost]
        [RequestSizeLimit(5 * 1024 * 1024)]
        public IActionResult Upload(IFormFile[] images)
        {
            var memoryStream = new MemoryStream();
            images.First().CopyTo(memoryStream);
            memoryStream.ToArray();


            return this.RedirectToAction(nameof(this.PhotoUploaded));
        }

        public IActionResult PhotoUploaded()
        {
            return this.View();
        }

    }
}
