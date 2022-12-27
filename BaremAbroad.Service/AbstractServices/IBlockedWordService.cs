using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IBlockedWordService
    {
        Task<BlockedWord> GetBlockedWordByIdAsync(int Id);
        Task<BlockedWord> RemoveBlockedWordByIdAsync(int Id);
        Task<BlockedWord> UpdateBlockedWordByIdAsync(BlockedWord blockedWord);
        Task<BlockedWord> AddBlockedWordAsync(BlockedWord blockedWord);
        Task<List<BlockedWord>> GetAllBlockedWordsAsync();
    }
}
