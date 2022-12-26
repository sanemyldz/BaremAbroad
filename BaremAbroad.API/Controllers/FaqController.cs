using BaremAbroad.Core.Services;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class FaqController : Controller
    {
        private readonly IFaqService _faqService;

        public FaqController(IFaqService faqService)
        {
            _faqService = faqService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetFaqByIdAsync(int Id)
        {
            return Ok(await _faqService.GetFaqByIdAsync(Id));
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveFaqByIdAsync(int Id)
        {
            await _faqService.RemoveFaqByIdAsync(Id);
            return Ok("Faq removed succesfully!");
        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateFaqByIdAsync(Faq faq)
        {
            await _faqService.UpdateFaqByIdAsync(faq);
            return Ok("Faq Updated Succesfully!");
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddFaqAsync(Faq faq)
        {
            return Ok(await _faqService.AddFaqAsync(faq));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllFaqsAsync()
        {
            return Ok(await _faqService.GetAllFaqsAsync());
        }
    }
}
