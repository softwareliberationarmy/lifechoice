using Application.WeighIn;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class WeighInController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<WeighIn>>> Get()
        {
            return await Mediator.Send(new List.Query()).ConfigureAwait(false);
        }

        [HttpGet("{date}")]
        public async Task<ActionResult<WeighIn>> GetByDate(DateOnly date)
        {
            return await Mediator.Send(new ByDate.Query(date)).ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<IActionResult> Create(WeighIn weighIn)
        {
            await Mediator.Send(new Create.Command(weighIn)).ConfigureAwait(false);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, WeighIn weighIn)
        {
            if (weighIn != null)
            {
                weighIn.Id = id;
                await Mediator.Send(new Edit.Command(weighIn)).ConfigureAwait(false);
            return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new Delete.Command(id)).ConfigureAwait(false);
            return Ok();
        }
    }
}
