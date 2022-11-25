using _3dhi.Data;
using _3dhi.Data.Entities;
using _3dhi.Models.DTOs;
using _3dhi.Models.InputModels;
using _3dhi.Models.ViewModels;
using _3dhi.Services.RealEstatesService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace _3dhi.Controllers
{
    public class RealEstatesController : Controller
    {
        private readonly ILogger<RealEstatesController> _logger;
        private readonly IRealEstatesService _realEstateService;
        private readonly IMapper _mapper;

        public RealEstatesController(ILogger<RealEstatesController> logger, IRealEstatesService realEstateService, IMapper mapper)
        {
            _logger = logger;
            _realEstateService = realEstateService;
        }

        // Beginning page for Real Estates
        [Route("~/realestates/")]
        public IActionResult RealEstates()
        {
            
            return this.View();

        }


        // Create 
        public async Task<IActionResult> CreateRealEstate(CreateRealEstateInputModel input)
        {
            var realEstate = await _realEstateService.CreateRealEstates(input);
            var viewModel = this._mapper.Map<RealEstatesViewModel>(realEstate);

            return this.View(viewModel);

        }

        [Route("~/realestates/getall")]
        public async Task<IActionResult> GetAllRealEstates()
        {
            List<RealEstate> realEstates = await _realEstateService.GetAllRealEstates();
            var viewModel = _mapper.Map<RealEstatesDTO>(realEstates);
            return View(viewModel);

        }

    }
}

