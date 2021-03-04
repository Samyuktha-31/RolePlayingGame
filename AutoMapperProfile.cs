using AutoMapper;
using RolePlayingGame.Models;
using RolePlayingGame.Models.Dtos.Character;

namespace RolePlayingGame
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}