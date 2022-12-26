using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
