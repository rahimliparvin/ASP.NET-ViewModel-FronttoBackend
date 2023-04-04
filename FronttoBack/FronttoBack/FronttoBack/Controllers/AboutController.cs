using Microsoft.AspNetCore.Mvc;

namespace FronttoBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
