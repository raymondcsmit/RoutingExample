using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Controllers
{
    public class AboutController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
