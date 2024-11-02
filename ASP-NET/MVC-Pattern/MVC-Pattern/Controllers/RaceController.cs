using Microsoft.AspNetCore.Mvc;

namespace MVC_Pattern.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
