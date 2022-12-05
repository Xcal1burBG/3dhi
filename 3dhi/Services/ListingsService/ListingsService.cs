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

        private readonly ApplicationDbContext _db;

        public ListingsService(ApplicationDbContext db)
        {
            this._db = db;
        }


        // Create Listing
        public async Task<Listing> CreateListing(CreateListingInputModel input)
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

            await this._db.Listings.AddAsync(listing);
            await this._db.SaveChangesAsync();

            return listing;
        }

        // Get listing by Id
        public async Task<Listing> GetListing(Guid listingId)
        {
            var listing = await this._db.Listings.FirstOrDefaultAsync(x => x.Id == listingId);
            return listing;
        }

        // Get all listings from all users
       public async Task<List<Listing>> GetAllListings()
        {
            var listings = await this._db.Listings.Where(x => x.EntityStatus == EntityStatus.Created).ToListAsync();
            return listings;
        }

        // Get all listings from one user
        public async Task<List<Listing>> GetAllListingsByUserId(Guid UserId)
        {
            var listings = await this._db.Listings
                .Where(x=>x.UserId == UserId)
                .Where(x => x.EntityStatus == EntityStatus.Created).
                ToListAsync();

            return listings;
        }


        // Edit listing
        public async Task<Listing> EditListing(EditListingInputModel input)
        {
            var listing = await this._db.Listings.FirstOrDefaultAsync(x => x.Id == input.Id);

            listing.Title = input.Title;
            listing.Description = input.Description;
            listing.Address = input.Address;
            listing.MainPhotoPath = input.MainPhotoPath;

            await this._db.SaveChangesAsync();
            return listing;
        }

        // Delete Listing
        public async Task DeleteListing(Guid listingId)
        {
            var listing = await this._db.Listings.FirstOrDefaultAsync(x => x.Id == listingId);
            listing.EntityStatus = EntityStatus.Deleted;

            await this._db.SaveChangesAsync();
        }

        // Admin Option only - Change User
        public async Task<Listing> EditListing(Guid id, Guid newUserId)
        {
            var listing = await this._db.Listings.FirstOrDefaultAsync(x => x.Id == id);
            listing.UserId = newUserId;

            await this._db.SaveChangesAsync();
            return listing;

        }

    }
}
