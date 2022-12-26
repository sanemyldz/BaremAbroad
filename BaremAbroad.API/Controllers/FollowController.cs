using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowController : Controller
    {
        private readonly IFollowService _followService;

        public FollowController(IFollowService followService)
        {
            _followService = followService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetFollowByIdAsync(int id)
        {
            return Ok(await _followService.GetFollowByIdAsync(id));
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveFollowByIdAsync(int id)
        {
            await _followService.RemoveFollowByIdAsync(id);
            return Ok("Follow removed succesfully!");
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddFollowEntryAsync(Follow follow)
        {
            return Ok(await _followService.AddFollowEntryAsync(follow));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllFollowersAsync(int userId)
        {
            return Ok(await _followService.GetAllFollowersAsync(userId));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllFollowedAsync(int userId)
        {
            return Ok(await _followService.GetAllFollowedAsync(userId));
        }
    }
}
