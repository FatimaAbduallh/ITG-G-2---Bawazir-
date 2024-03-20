using Microsoft.AspNetCore.Mvc;

namespace GameZon.Controllers
{
    public class Games : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
