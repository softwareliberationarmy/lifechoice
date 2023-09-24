using AutoMapper;
using MediatR;
using Persistence;

namespace Application.WeighIn;

public static class Edit
{
    public class Command : IRequest
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
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var weighIn = await _context.WeighIns.FindAsync(new object[] { request.WeighIn.Id },
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                _mapper.Map(request.WeighIn, weighIn);
                await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }
}