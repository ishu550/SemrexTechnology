using Microsoft.AspNetCore.Mvc;

namespace SemrexTechnology.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
