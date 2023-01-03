using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetSchoolByIdAsync(int Id)
        {
            return Ok(await _schoolService.GetSchoolByIdAsync(Id));
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveSchoolByIdAsync(int Id)
        {
            await _schoolService.RemoveSchoolByIdAsync(Id);
            return NoContent();
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateSchoolByIdAsync(School school)
        {
            await _schoolService.UpdateSchoolByIdAsync(school);
            return NoContent();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddSchoolAsync(School school)
        {
            return Ok(await _schoolService.AddSchoolAsync(school));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSchoolsAsync()
        {
            return Ok(await _schoolService.GetAllSchoolsAsync());
        }
    }
}