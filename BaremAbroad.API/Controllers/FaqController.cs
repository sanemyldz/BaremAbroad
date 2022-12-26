using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
