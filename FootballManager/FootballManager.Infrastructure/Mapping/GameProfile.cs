using AutoMapper;
using FootballManager.Domain.Entities;
using FootballManager.Infrastructure.ViewModel;

namespace FootballManager.Infrastructure.Mapping
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<GameModel, Game>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.GameId))
                .ReverseMap();
        }
    }
}
