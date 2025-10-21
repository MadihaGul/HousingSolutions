using HousingSolutions.Application.Common.Interfaces;
using HousingSolutions.Application.Handlers.Doors;
using HousingSolutions.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HousingSolutions.Application.Doors
{
    public class GetDoorsHandler : IRequestHandler<GetDoorsQuery, List<Door>>
    {
        private readonly IApplicationDbContext _db;

        public GetDoorsHandler(IApplicationDbContext db) => _db = db;

        public async Task<List<Door>> Handle(GetDoorsQuery request, CancellationToken ct)
            => await _db.Doors.AsNoTracking().ToListAsync(ct);
    }
}
