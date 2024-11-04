using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MVC_Pattern.Data;
using MVC_Pattern.Models;

namespace MVC_Pattern.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RaceController(ApplicationDbContext context) { 
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList();
            return View(races);
        }
    }
}
