using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
