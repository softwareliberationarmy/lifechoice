using System.Diagnostics.CodeAnalysis;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.WeighIn;

public static class ByDate
{
    [SuppressMessage("Naming", "CA1724: Type names should not match namespaces", Justification = "This is a nested class, and Query is a well-known MediatR keyword")]
    public class Query : IRequest<Domain.WeighIn>
    {
        public DateOnly Date { get; }

        public Query(DateOnly date)
        {
            Date = date;
        }
    }

    public class Handler : IRequestHandler<Query, Domain.WeighIn>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Domain.WeighIn> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.WeighIns.FirstOrDefaultAsync(w => w.Date == request.Date, cancellationToken)
                .ConfigureAwait(false);
        }
    }
}