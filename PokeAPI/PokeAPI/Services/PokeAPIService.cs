using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using PokeAPI.DTO;
using PokeAPI.Interfaces;
using System.Diagnostics;

namespace PokeAPI.Services
{
    public class PokeAPIService : IPokeAPIService
    {
        private readonly IHttpClientFactory _clientFactory;
        public PokeAPIService(IHttpClientFactory clientFactory)
        =>
            _clientFactory = clientFactory;
       
        public async Task<ListDTO> GetListAsync(string url)
        {
                var client = _clientFactory.CreateClient("PokeAPI");
                var request = new HttpRequestMessage(HttpMethod.Get,$"{url}");
                var response = await client.SendAsync(request);
                if (!response.IsSuccessStatusCode) throw new Exception("Error al traer el listado");
                return await response.Content.ReadFromJsonAsync<ListDTO>();
            
        }

    }
}
