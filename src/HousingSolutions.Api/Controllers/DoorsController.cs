using HousingSolutions.Application.Handlers.Doors;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DoorsController : ControllerBase
{
    private readonly IMediator _mediator;
    public DoorsController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> GetDoors() =>
        Ok(await _mediator.Send(new GetDoorsQuery()));
}
