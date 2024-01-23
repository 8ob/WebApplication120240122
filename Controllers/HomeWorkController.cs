using Microsoft.AspNetCore.Mvc;

namespace WebApplication120240122.Controllers
{
    public class HomeWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
