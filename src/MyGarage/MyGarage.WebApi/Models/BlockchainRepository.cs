using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Models
{
    public class BlockchainRepository : IBlockchainRepository
    {
        private readonly AppDbContext _appDbContext;
        public BlockchainRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Block AddRepoBlock(Block block)
        {
            var addedBlock = _appDbContext.Blocks.Add(block);

            _appDbContext.SaveChanges();
            return addedBlock.Entity;
        }

        public IEnumerable<Block> GetBlockchain()
        {
            return _appDbContext.Blocks;
        }
    }
}
