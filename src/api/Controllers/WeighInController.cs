using Application.WeighIn;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace api.Controllers
{
    public class WeighInController : BaseApiController
    {
        private readonly IMediator _mediator;

        public WeighInController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<WeighIn>>> Get()
        {
            return await _mediator.Send(new List.Query());
        }

        //[HttpGet("{date}")]
        //public async Task<ActionResult<WeighIn>> GetByDate(DateOnly date)
        //{

        //}
    }
}
