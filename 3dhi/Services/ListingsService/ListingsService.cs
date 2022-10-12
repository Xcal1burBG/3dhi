using _3dhi.Data;
using _3dhi.Data.Entities;
using _3dhi.Enum;
using _3dhi.Models.InputModels;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace _3dhi.Services.ListingsService
{
    public class ListingsService : IListingsService
    {

        private readonly ApplicationDbContext db;

        public ListingsService(ApplicationDbContext db)
        {
            this.db = db;
        }


        // Create Listing
        public async Task<Listing> CreateListing(CreateListingInput input)
        {
            var listing = new Listing
            {
                Id = new Guid(),
                UserId = input.UserId,
                Title = input.Title,
                Description = input.Description,
                Address = input.Address,
                MainPhotoPath = input.MainPhotoPath,
                EntityStatus = EntityStatus.Created

            };

            await this.db.Listings.AddAsync(listing);
            await this.db.SaveChangesAsync();

            return listing;
        }

        // Get Listing 
        public async Task<Listing> GetListing(Guid listingId)
        {
            var listing = await this.db.Listings.FirstOrDefaultAsync(x => x.Id == listingId);
            return listing;
        }

        // Edit Listing
        public async Task<Listing> EditListing(EditListingInput input)
        {
            var listing = await this.db.Listings.FirstOrDefaultAsync(x => x.Id == input.Id);

            listing.Title = input.Title;
            listing.Description = input.Description;
            listing.Address = input.Address;
            listing.MainPhotoPath = input.MainPhotoPath;

            await this.db.SaveChangesAsync();
            return listing;
        }

        // Delete Listing
        public async Task DeleteListing(Guid listingId)
        {
            var listing = await this.db.Listings.FirstOrDefaultAsync(x => x.Id == listingId);
            listing.EntityStatus = EntityStatus.Deleted;

            await this.db.SaveChangesAsync();
        }

        // Admin Option only - Change User
        public async Task<Listing> EditListing(Guid id, Guid newUserId)
        {
            var listing = await this.db.Listings.FirstOrDefaultAsync(x => x.Id == id);
            listing.UserId = newUserId;

            await this.db.SaveChangesAsync();
            return listing;

        }

    }
}
