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
        Blockchain ClientsBlockchain = new Blockchain();
        private readonly IBlockchainRepository _blockchainRepository;

        public ClientController(IClientRepository clientRepository, IBlockchainRepository blockchainRepository)
        {
            _clientRepository = clientRepository;
            _blockchainRepository = blockchainRepository;
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

            var kloc = new Block(DateTime.Now, null, $"{client.ClientId}; {client.Name}; {client.Comment}; {client.IsGood}");


            ClientsBlockchain.AddBlock(kloc);
            var addedblock = _blockchainRepository.AddRepoBlock(kloc);

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
    public class Blockchain
    {
        public IList<Block> Chain { set; get; }
        public Blockchain()
        {
            InitializeChain();
            AddGenesisBlock();
        }
        public void InitializeChain()
        {
            Chain = new List<Block>();
        }
        public Block CreateGenesisBlock()
        {
            return new Block(DateTime.Now, null, "{}");
        }
        public void AddGenesisBlock()
        {
            Chain.Add(CreateGenesisBlock());
        }
        public Block GetLatestBlock()
        {
            return Chain[Chain.Count - 1];
        }
        public void AddBlock(Block block)
        {
            Block latestBlock = GetLatestBlock();
            block.Index = latestBlock.Index + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Hash = block.CalculateHash();
            Chain.Add(block);
        }
    }
}
