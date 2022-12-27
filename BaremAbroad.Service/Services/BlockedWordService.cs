using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class BlockedWordService : IBlockedWordService
    {
        private readonly IGenericRepository<BlockedWord> _genericRepository;

        public BlockedWordService(IGenericRepository<BlockedWord> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<BlockedWord> AddBlockedWordAsync(BlockedWord blockedWord)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BlockedWord>> GetAllBlockedWordsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<BlockedWord> GetBlockedWordByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public async Task<BlockedWord> RemoveBlockedWordByIdAsync(int Id)
        {
            throw new NotImplementedException();

        }

        public async Task<BlockedWord> UpdateBlockedWordByIdAsync(BlockedWord blockedWord)
        {
            throw new NotImplementedException();
        }
    }
}
