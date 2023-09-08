using Application.WeighIn;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class WeighInController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<WeighIn>>> Get()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{date}")]
        public async Task<ActionResult<WeighIn>> GetByDate(DateOnly date)
        {
            return await Mediator.Send(new ByDate.Query(date));
        }

        [HttpPost]
        public async Task<IActionResult> Create(WeighIn weighIn)
        {
            await Mediator.Send(new Create.Command(weighIn));
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, WeighIn weighIn)
        {
            weighIn.Id = id;
            await Mediator.Send(new Edit.Command(weighIn));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new Delete.Command(id));
            return Ok();
        }
    }
}
