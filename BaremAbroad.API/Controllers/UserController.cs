﻿using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
