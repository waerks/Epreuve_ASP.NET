using UI.Mappers;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class EmpruntController : Controller
	{
		private EmpruntService _empruntService;

		public EmpruntController()
		{
			_empruntService = new EmpruntService();
		}

		// GET: EmpruntController
		public ActionResult Index()
		{
			try
			{
				IEnumerable<EmpruntListItem> model = _empruntService.Get().Select(BLL => BLL.ToListItem());
				return View(model);
			}
			catch
			{
				return RedirectToAction("Error", "Home");
			}
		}
	}
}
