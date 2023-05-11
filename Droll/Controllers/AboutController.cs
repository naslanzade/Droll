using Microsoft.AspNetCore.Mvc;

namespace Droll.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
