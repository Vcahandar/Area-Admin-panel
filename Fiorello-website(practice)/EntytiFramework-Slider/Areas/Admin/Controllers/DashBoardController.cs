﻿using Microsoft.AspNetCore.Mvc;

namespace EntytiFramework_Slider.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {

            return View();
        }
    }
}
