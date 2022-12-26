using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    public class BlogArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
