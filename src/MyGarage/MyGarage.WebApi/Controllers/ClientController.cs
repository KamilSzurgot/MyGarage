using Microsoft.AspNetCore.Mvc;
using MyGarage.Shared;
using MyGarage.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public IActionResult GetAllClients()
        {
            return Ok(_clientRepository.GetAllClients());
        }

        [HttpGet("{id}")]
        public IActionResult GetClientById(int id)
        {
            return Ok(_clientRepository.GetClientById(id));
        }

        [HttpPost]
        public IActionResult CreateClient([FromBody] Client client)
        {
            if (client == null)
                return BadRequest();

            if (client.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdClient = _clientRepository.AddClient(client);

            return Created("client", createdClient);
        }

        [HttpPut]
        public IActionResult UpdateClient([FromBody] Client client)
        {
            if (client == null)
                return BadRequest();

            if (client.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clientToUpdate = _clientRepository.GetClientById(client.ClientId);

            if (clientToUpdate == null)
                return NotFound();

            _clientRepository.UpdateClient(client);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            if (id == 0)
                return BadRequest();

            var clientToDelete = _clientRepository.GetClientById(id);
            if (clientToDelete == null)
                return NotFound();

            _clientRepository.DeleteClient(id);

            return NoContent();//success
        }
    }
}
