using Microsoft.AspNetCore.Mvc;

namespace Group2Flight.Areas.Airlines.Controllers
{
	[Area("Airlines")]
	public class FlightsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Manage()
		{
			return Content("Airline Manage Flights Page");
		}

		public IActionResult Regulation()
		{
			return Content("Airline Regulation Page");
		}
	}
}