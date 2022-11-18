using _3dhi.Services.AdditionalService;
using _3dhi.Services.IncomesService;
using _3dhi.Services.ListingsService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3dhi.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ILogger<ManagementController> _logger;
        private readonly IListingsService _listingService;
        private readonly ICostsService _costsService;
        private readonly IIncomesService _incomesService;
        private readonly IMapper _mapper;

        public ManagementController(ILogger<ManagementController> logger, IListingsService listingService, 
            ICostsService costsService, IIncomesService incomesService, IMapper mapper)
        {
            _logger = logger;
            _listingService = listingService;
            _costsService = costsService;
            _incomesService = incomesService;
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
