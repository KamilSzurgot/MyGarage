using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Models
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClients();
        Client GetClientById(int clientId);
        Client AddClient(Client client);
        Client UpdateClient(Client client);
        void DeleteClient(int clientId);
    }
}
