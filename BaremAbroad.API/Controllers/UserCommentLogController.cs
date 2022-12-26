using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    public class UserCommentLogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
