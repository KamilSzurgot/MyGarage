using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyGarage.Blazor.Services
{
    public class ClientDataService : IClientDataService
    {
        private readonly HttpClient _httpClient;
        
        public ClientDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Client> AddClient(Client client)
        {
            var clientJson = new StringContent(JsonSerializer.Serialize(client), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/client", clientJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Client>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteClient(int clientId)
        {
            await _httpClient.DeleteAsync($"api/client/{clientId}");
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Client>>
                (await _httpClient.GetStreamAsync($"api/client"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Client> GetClientDetails(int clientId)
        {
            return await JsonSerializer.DeserializeAsync<Client>
                (await _httpClient.GetStreamAsync($"api/client/{clientId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateClient(Client client)
        {
            var clientJson = new StringContent(JsonSerializer.Serialize(client), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/client", clientJson);
        }
    }
}
