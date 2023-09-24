using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[assembly:CLSCompliant(true)]
[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    private IMediator _mediator;
    protected IMediator Mediator => _mediator ??= 
        HttpContext.RequestServices.GetRequiredService<IMediator>();
}
