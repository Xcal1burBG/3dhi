using _3dhi.Data.Entities;
using _3dhi.Models.InputModels;

namespace _3dhi.Services.ListingsService
{
    public interface IListingsService
    {
        // Create Listing
        public Task<Listing> CreateListing(CreateListingInputModel input);


        // Get Listing 
        public Task<Listing> GetListing(Guid listingId);
        

        // Edit Listing
        public Task<Listing> EditListing(EditListingInputModel input);


        // Delete Listing
        public Task DeleteListing(Guid listingId);


        // Admin Option only - Change User
        public Task<Listing> EditListing(Guid id, Guid newUserId);
        
    }
}
