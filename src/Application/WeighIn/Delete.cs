using MediatR;
using Persistence;

namespace Application.WeighIn;

public class Delete
{
    public class Command: IRequest
    {
        public int Id { get; }

        public Command(int id)
        {
            Id = id;
        }
    }

    public class Handler: IRequestHandler<Command>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var weighIn = await _context.WeighIns.FindAsync(request.Id);
            _context.Remove(weighIn);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}