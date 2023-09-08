using MediatR;
using Persistence;

namespace Application.WeighIn;

public class Create
{
    public class Command: IRequest
    {
        public Domain.WeighIn WeighIn { get; }

        public Command(Domain.WeighIn weighIn)
        {
            WeighIn = weighIn;
        }
    }

    public class Handler : IRequestHandler<Command>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            _context.WeighIns.Add(request.WeighIn);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}