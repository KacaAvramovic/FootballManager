using Microsoft.EntityFrameworkCore;
using FootballManager.Domain.Entities;
using System.Threading.Tasks;

namespace FootballManager.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Team> Teams { get; set; }
        DbSet<Game> Games { get; set; }

        Task<int> SaveChangesAsync();
    }
}
