﻿using Microsoft.AspNetCore.Mvc;

namespace FronttoBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
