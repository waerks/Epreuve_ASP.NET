using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class CollectionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
