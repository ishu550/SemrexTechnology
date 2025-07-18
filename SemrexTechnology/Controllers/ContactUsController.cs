using Microsoft.AspNetCore.Mvc;

namespace SemrexTechnology.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
