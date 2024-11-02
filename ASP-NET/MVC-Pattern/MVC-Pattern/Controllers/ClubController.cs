using Microsoft.AspNetCore.Mvc;

namespace MVC_Pattern.Controllers
{
    public class ClubController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
