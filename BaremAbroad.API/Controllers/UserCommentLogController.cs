using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentLogController : Controller
    {
        private readonly IUserCommentLogService _userCommentLogService;

        public UserCommentLogController(IUserCommentLogService userCommentLogService)
        {
            _userCommentLogService = userCommentLogService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserCommentLogByIdAsync(int Id)
        {
            return Ok(await _userCommentLogService.GetUserCommentLogByIdAsync(Id));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddUserCommentLogAsync(UserCommentLog userCommentLog)
        {
            return Ok(await _userCommentLogService.AddUserCommentLogAsync(userCommentLog));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUserCommentLogsAsync(int id)
        {
            return Ok(await _userCommentLogService.GetAllUserCommentLogsAsync(id));
        }
    }
}