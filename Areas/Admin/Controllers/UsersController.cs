using Microsoft.AspNetCore.Mvc;

namespace Group2Flight.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UsersController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Manage()
		{
			return Content("Admin Manage Users Page");
		}

		public IActionResult Rights()
		{
			return Content("Admin Rights and Obligations Page");
		}
	}
}