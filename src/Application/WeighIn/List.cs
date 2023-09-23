using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.WeighIn
{
    public class List
    {
        public class Query : IRequest<List<Domain.WeighIn>>
        {

        }

        public class Handler : IRequestHandler<Query, List<Domain.WeighIn>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Domain.WeighIn>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.WeighIns.ToListAsync(cancellationToken);
            }
        }
    }
}
