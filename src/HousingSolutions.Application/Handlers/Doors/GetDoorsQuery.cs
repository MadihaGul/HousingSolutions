
using HousingSolutions.Domain.Entities;
using MediatR;


namespace HousingSolutions.Application.Handlers.Doors
{
    public record GetDoorsQuery() : IRequest<List<Door>>;

}
