using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace api.Controllers
{
    public class WeighInController : BaseApiController
    {
        private readonly DataContext _context;
        public WeighInController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<WeighIn>>> Get()
        {
            return await _context.WeighIns.ToListAsync();
        }
    }
}
