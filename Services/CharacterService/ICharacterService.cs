using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet31_rpg.Dtos.Character;
using dotnet31_rpg.Models;

namespace dotnet31_rpg.Services
{
    public interface ICharacterService
        {
            Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
            Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
            Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        }
}