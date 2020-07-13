using MediatR;
using FootballManager.Domain.Entities;
using FootballManager.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.Service.Features.GameFeatures.Commands
{
    public class CreateGameCommand : IRequest<int>
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }

        public class CreateGameCommandHandler : IRequestHandler<CreateGameCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public CreateGameCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreateGameCommand request, CancellationToken cancellationToken)
            {
                var game = new Game();
                game.Team1 = request.Team1;
                game.Team2 = request.Team2;

                _context.Games.Add(game);
                await _context.SaveChangesAsync();
                return game.Id;
            }
        }
    }
}
