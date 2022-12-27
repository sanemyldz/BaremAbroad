using BaremAbroad.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockedWordController : Controller
    {
        private readonly IBlockedWordService _blockedWordService;

        public BlockedWordController(IBlockedWordService blockedWordService)
        {
            _blockedWordService = blockedWordService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBlockedWordByIdAsync(int Id)
        {
            return Ok(await _blockedWordService.GetBlockedWordByIdAsync(Id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllBlockedWordsAsync()
        {
            return Ok(await _blockedWordService.GetAllBlockedWordsAsync());
        }

    }
}