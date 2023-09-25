using System.Diagnostics.CodeAnalysis;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.WeighIn
{
    public static class List
    {
        [SuppressMessage("Naming", "CA1724: Type names should not match namespaces", Justification = "This is a nested class, and Query is a well-known MediatR keyword")]
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
                return await _context.WeighIns.ToListAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
