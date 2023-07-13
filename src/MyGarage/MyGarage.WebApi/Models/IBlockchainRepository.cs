using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Models
{
    public interface IBlockchainRepository
    {
        public Block AddRepoBlock(Block block);
        public IEnumerable<Block> GetBlockchain();
    }
}
