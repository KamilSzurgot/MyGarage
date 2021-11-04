using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.Blazor.Services
{
    public interface IClientDataService
    {
        Task<IEnumerable<Client>> GetAllClients();
        Task<Client> GetClientDetails(int clientId);
        Task<Client> AddClient(Client client);
        Task UpdateClient(Client client);
        Task Deleteclient(int clientId);
    }
}
