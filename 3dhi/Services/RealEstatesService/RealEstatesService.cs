using _3dhi.Controllers;
using _3dhi.Data;
using _3dhi.Data.Entities;
using _3dhi.Models.DTOs;
using _3dhi.Models.InputModels;
using _3dhi.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace _3dhi.Services.RealEstatesService
{
    public class RealEstatesService : IRealEstatesService
    {
        private readonly ApplicationDbContext _db;
        public RealEstatesService(ApplicationDbContext db)
        {
            _db = db;
        }


        // Create RealEstate
        public async Task<RealEstate> CreateRealEstates(CreateRealEstateInputModel input)
        {
            var realEstate = new RealEstate
            {
                Id = Guid.NewGuid(),
                OwnerName = input.OwnerName,
                Location = input.Location,
                Description = input.Description,
                NumberOfRooms = input.NumberOfRooms,
                FloorNumber = input.FloorNumber,
                Price = input.Price,
                PhotoPaths = input.PhotoPaths

            };

            await _db.RealEstates.AddAsync(realEstate);
            await _db.SaveChangesAsync();

            return realEstate;
        }

        // Get RealEstate
        // Get All RealEstates

        public async Task<List<RealEstate>> GetAllRealEstates()
        {
            var realEstates = await this._db.RealEstates.Where(x => x.EntityStatus == Enum.EntityStatus.Created).ToListAsync();
            return realEstates;
        }
        // Edit RealEstate
        // Delete RealEstate
    }
}
