using _3dhi.Data.Entities;
using _3dhi.Models.InputModels;

namespace _3dhi.Services.RealEstatesService
{
    public interface IRealEstatesService
    {
        public Task<RealEstate> CreateRealEstates(CreateRealEstateInputModel input);
        public Task<List<RealEstate>> GetAllRealEstates();
    }
}
