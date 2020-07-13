using MediatR;
using FootballManager.Domain.Entities;
using FootballManager.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.Service.Features.GameFeatures.Commands
{
    public class UpdateGameCommand : IRequest<int>
    {
        public int Id { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }

        public class UpdateGamerCommandHandler : IRequestHandler<UpdateGameCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpdateGamerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateGameCommand request, CancellationToken cancellationToken)
            {
                var cust = _context.Games.Where(a => a.Id == request.Id).FirstOrDefault();

                if (cust == null)
                {
                    return default;
                }
                else
                {
                    var game = new Game();
                    game.Team1 = request.Team1;
                    game.Team2 = request.Team2;
                    await _context.SaveChangesAsync();
                    return cust.Id;
                }
            }
        }
    }
}
