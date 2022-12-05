using _3dhi.Data.Entities;
using _3dhi.Enum;
using _3dhi.Models.InputModels;

namespace _3dhi.Services.ListingsService
{
    public interface IListingsService
    {
        // Create Listing
        public Task<Listing> CreateListing(CreateListingInputModel input);


        // Get Listing 
        public Task<Listing> GetListing(Guid listingId);

        // Get all listings from all users
        public Task<List<Listing>> GetAllListings();

        // Get all listings from one user
        public Task<List<Listing>> GetAllListingsByUserId(Guid UserId);
        
        // Edit Listing
        public Task<Listing> EditListing(EditListingInputModel input);


        // Delete Listing
        public Task DeleteListing(Guid listingId);


        // Admin Option only - Change User
        public Task<Listing> EditListing(Guid id, Guid newUserId);
        
    }
}
