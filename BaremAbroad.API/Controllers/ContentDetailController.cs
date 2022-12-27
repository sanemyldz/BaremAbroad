using BaremAbroad.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentDetailController : Controller
    {
        private readonly IContentDetailService _contentDetailService;

        public ContentDetailController(IContentDetailService contentDetailService)
        {
            _contentDetailService = contentDetailService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetContentDetailByIdAsync(int Id)
        {
            return Ok(await _contentDetailService.GetContentDetailByIdAsync(Id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllContentDetailsAsync()
        {
            return Ok(await _contentDetailService.GetAllContentDetailsAsync());
        }
    }
}
