using HousingSolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace HousingSolutions.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Door> Doors { get; }
        DbSet<Booking> Bookings { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
