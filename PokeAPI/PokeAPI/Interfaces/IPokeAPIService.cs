using PokeAPI.DTO;

namespace PokeAPI.Interfaces
{
    public interface IPokeAPIService
    {
        Task<ListDTO> GetListAsync(string url);
    }
}