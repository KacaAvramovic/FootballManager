using MediatR;
using Microsoft.EntityFrameworkCore;
using FootballManager.Domain.Entities;
using FootballManager.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FootballManager.Service.Features.GameFeatures.Queries
{
    public class GetAllGameQuery : IRequest<IEnumerable<Game>>
    {

        public class GetAllGameQueryHandler : IRequestHandler<GetAllGameQuery, IEnumerable<Game>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllGameQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Game>> Handle(GetAllGameQuery request, CancellationToken cancellationToken)
            {
                var gameList = await _context.Games.ToListAsync();
                if (gameList == null)
                {
                    return null;
                }
                return gameList.AsReadOnly();
            }
        }
    }
}
