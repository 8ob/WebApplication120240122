using Microsoft.AspNetCore.Mvc;
using WebApplication120240122.Models;

namespace WebApplication120240122.Controllers
{
	public class ApiController : Controller
	{
		private readonly MyDBContext _dbContext;
		public ApiController(MyDBContext dbContext)
		{
			
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Cities()
		{
			var cities=_dbContext.Addresses.Select(c => c.City).Distinct();
			return Json(cities);

		}
	}
}
