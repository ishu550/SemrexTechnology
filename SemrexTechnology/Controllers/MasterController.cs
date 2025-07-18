using Microsoft.AspNetCore.Mvc;

namespace SemrexTechnology.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
