using Microsoft.AspNetCore.Mvc;
using MyGarage.Shared;
using MyGarage.WebApi.Models;
using System;
using System.Collections.Generic;

namespace MyGarage.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockchainController : Controller
    {
        private readonly IBlockchainRepository _blockchainRepository;

        public BlockchainController(IBlockchainRepository blockchainRepository)
        {
            _blockchainRepository = blockchainRepository;
        }

        [HttpGet]
        public IActionResult GetBlockchain()
        {
            return Ok(_blockchainRepository.GetBlockchain());
        }
    }
}
