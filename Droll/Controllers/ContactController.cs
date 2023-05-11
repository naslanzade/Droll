using Microsoft.AspNetCore.Mvc;

namespace Droll.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
