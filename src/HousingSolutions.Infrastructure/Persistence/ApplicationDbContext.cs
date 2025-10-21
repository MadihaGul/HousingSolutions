using HousingSolutions.Application.Common.Interfaces;
using HousingSolutions.Application.Common.Interfaces;
using HousingSolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HousingSolutions.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Door> Doors { get; set; }
        public DbSet<Booking> Bookings => Set<Booking>();

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => base.SaveChangesAsync(cancellationToken);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Door>().HasData(
                new Door { Id = 1, Name = "Main Entrance", IsLocked = true },
                new Door { Id = 2, Name = "Garage", IsLocked = false }
            );
                modelBuilder.Entity<Booking>().HasData(
                new Booking { Id = 3, ResidentName = "Resident 1", StartTime = new DateTime(2025, 10, 21, 9, 0, 0), EndTime = new DateTime(2025, 10, 21, 12, 0, 0) },
                new Booking { Id = 4, ResidentName = "Resident 1", StartTime = new DateTime(2025, 10, 21, 13, 0, 0), EndTime = new DateTime(2025, 10, 21, 16, 0, 0) }
            );

        }


    }
}

