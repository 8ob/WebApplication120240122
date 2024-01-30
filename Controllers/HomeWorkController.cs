using Microsoft.AspNetCore.Mvc;
using WebApplication120240122.Models;

namespace WebApplication120240122.Controllers
{
	public class HomeWorkController : Controller
	{
		private readonly MyDBContext _dbContext;

		public HomeWorkController(MyDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Register()
		{
			return View();
		}

		[HttpGet]
		
		public IActionResult CheckAccount(string Name)
		{
			bool accountExists = CheckIfAccountExists(Name);

			if (accountExists)
			{
				return Content("帳號已存在");
			}
			else
			{
				return Content("");
			}
		}

        private bool CheckIfAccountExists(string name)
        {
			if (string.IsNullOrEmpty(name)) { }
            var existingMember = _dbContext.Members.FirstOrDefault(a => a.Name.ToUpper() == name.ToUpper());

            return existingMember != null;
        }

        [HttpGet]
		
		public IActionResult GetMembers()
		{
			var names = _dbContext.Members.Select(a => a.Name).Distinct().ToList();
			return Json(names);
		}
	}
}
