using BaremAbroad.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCountryByIdAsync(int Id)
        {
            return Ok(await _countryService.GetCountryByIdAsync(Id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCountriesAsync()
        {
            return Ok(await _countryService.GetAllCountriesAsync());
        }
    }
}
