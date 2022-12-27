using BaremAbroad.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : Controller
    {
        private readonly IProgramService _programService;

        public ProgramController(IProgramService programService)
        {
            _programService = programService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProgramByIdAsync(int Id)
        {
            return Ok(await _programService.GetProgramByIdAsync(Id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllProgramsAsync()
        {
            return Ok(await _programService.GetAllProgramsAsync());
        }
    }
}
