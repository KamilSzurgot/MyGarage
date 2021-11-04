using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Models
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Client AddClient(Client client)
        {
            var addedEntity = _appDbContext.Clients.Add(client);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public void DeleteClient(int clientId)
        {
            var foundClient = _appDbContext.Clients.FirstOrDefault(e => e.ClientId == clientId);
            if (foundClient == null) return;

            _appDbContext.Clients.Remove(foundClient);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _appDbContext.Clients;
        }

        public Client GetClientById(int clientId)
        {
            return _appDbContext.Clients.FirstOrDefault(c => c.ClientId == clientId);
        }

        public Client UpdateClient(Client client)
        {
            var foundClient = _appDbContext.Clients.FirstOrDefault(e => e.ClientId == client.ClientId);

            if (foundClient != null)
            {
                foundClient.Name = client.Name;
                foundClient.PhoneNumber = client.PhoneNumber;
                foundClient.Email = client.Email;
                foundClient.Comment = client.Comment;
                foundClient.IsGood = client.IsGood;

                _appDbContext.SaveChanges();

                return foundClient;
            }

            return null;
        }
    }
}
