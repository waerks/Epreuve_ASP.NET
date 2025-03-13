using UI.Mappers;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class JeuController : Controller
	{
		private JeuService _jeuService;

		public JeuController()
		{
			_jeuService = new JeuService();
		}

		// GET: JeuController
		public ActionResult Index()
		{
			try
			{
				IEnumerable<JeuListItem> model = _jeuService.Get().Select(BLL => BLL.ToListItem());
				return View(model);
			}
			catch
			{
				return RedirectToAction("Error", "Home");
			}
		}
	}
}
