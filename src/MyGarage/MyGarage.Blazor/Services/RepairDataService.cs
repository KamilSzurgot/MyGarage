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
    public class RepairDataService : IRepairDataService
    {
        private readonly HttpClient _httpClient;

        public RepairDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Repair> AddRepair(Repair repair)
        {
            var repairJson = new StringContent(JsonSerializer.Serialize(repair), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/repair", repairJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Repair>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteRepair(int repairId)
        {
            await _httpClient.DeleteAsync($"api/repair/{repairId}");
        }

        public async Task<IEnumerable<Repair>> GetAllRepairs()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Repair>>
                (await _httpClient.GetStreamAsync($"api/repair"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Repair> GetRepairDetails(int repairId)
        {
            return await JsonSerializer.DeserializeAsync<Repair>
                (await _httpClient.GetStreamAsync($"api/repair/{repairId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateRepair(Repair repair)
        {
            var repairJson = new StringContent(JsonSerializer.Serialize(repair), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/repair", repairJson);
        }
    }
}
