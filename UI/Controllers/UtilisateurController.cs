using UI.Mappers;
using UI.Models.Utilisateur;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class UtilisateurController : Controller
	{
		private UtilisateurService _utilisateurService;

		public UtilisateurController()
		{
			_utilisateurService = new UtilisateurService();
		}

		// GET: UtilisateurController
		public ActionResult Index()
		{
			try
			{
				IEnumerable<UtilisateurListItem> model = _utilisateurService.Get().Select(BLL => BLL.ToListItem());

				return View(model);
			} catch
			{
				return RedirectToAction("Error", "Home");
			}
		}

		// GET: UtilisateurController/Details/5
		public ActionResult Details(int id)
		{
			try
			{
				UtilisateurDetail model = _utilisateurService.Get(id).ToDetail();
				return View(model);
			} catch
			{
				return RedirectToAction("Error", "Home");
			}
		}

		// GET: UtilisateurController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: UtilisateurController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: UtilisateurController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: UtilisateurController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: UtilisateurController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: UtilisateurController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
