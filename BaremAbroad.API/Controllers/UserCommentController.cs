using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    public class UserCommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
