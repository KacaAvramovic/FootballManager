using MediatR;
using Microsoft.EntityFrameworkCore;
using FootballManager.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.Service.Features.GameFeatures.Commands
{
    public class DeleteGameByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeleteGameByIdCommandHandler : IRequestHandler<DeleteGameByIdCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public DeleteGameByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(DeleteGameByIdCommand request, CancellationToken cancellationToken)
            {
                var game = await _context.Games.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
                if (game == null) return default;
                _context.Games.Remove(game);
                await _context.SaveChangesAsync();
                return game.Id;
            }
        }
    }
}
