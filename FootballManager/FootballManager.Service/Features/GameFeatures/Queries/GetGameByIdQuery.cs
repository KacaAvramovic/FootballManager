using MediatR;
using FootballManager.Domain.Entities;
using FootballManager.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.Service.Features.GameFeatures.Queries
{
    public class GetGameByIdQuery : IRequest<Game>
    {
        public int Id { get; set; }
        public class GetGameByIdQueryHandler : IRequestHandler<GetGameByIdQuery, Game>
        {
            private readonly IApplicationDbContext _context;
            public GetGameByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<Game> Handle(GetGameByIdQuery request, CancellationToken cancellationToken)
            {
                var game = _context.Games.Where(a => a.Id == request.Id).FirstOrDefault();
                if (game == null) return null;
                return game;
            }
        }
    }
}
