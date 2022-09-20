using _3dhi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _3dhi.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=3hdi;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<string>().HaveColumnType("nvarchar(200)");
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<decimal>().HavePrecision(10,2);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pricing>().Property(x => x.Price).HasPrecision(6, 2);
            modelBuilder.Entity<Listing>().Property(x => x.Description).HasColumnType("nvarchar(1000)");
            modelBuilder.Entity<Message>().HasNoKey();
            modelBuilder.Entity<Occupancy>().HasNoKey();
            modelBuilder.Entity<Pricing>().HasNoKey();
            modelBuilder.Entity<ListingStats>().HasNoKey();
        }
        public virtual DbSet<Listing> Listings { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Occupancy> Occupancies { get; set; }
        public virtual DbSet<PhotoPath> PhotoPaths { get; set; }
        public virtual DbSet<Pricing> Pricing { get; set; }
        public virtual DbSet<RealEstate> RealEstates { get; set; }
        public virtual DbSet<ListingStats> ListingStats { get; set; }


    }
}

