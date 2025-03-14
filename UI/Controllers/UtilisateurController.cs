using UI.Mappers;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Common.Repositories;
using BLL.Entities;

namespace UI.Controllers
{
	public class UtilisateurController : Controller
	{
		private readonly IUtilisateurService<Utilisateur> _utilisateurService;

		public UtilisateurController(IUtilisateurService<Utilisateur> utilisateurService)
		{
			_utilisateurService = utilisateurService;
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
		public ActionResult Create(UtilisateurCreateForm form)
		{
			try
			{
				if (!form.Consent)
					ModelState.AddModelError(nameof(form.Consent), "Vous devez accepter les conditions générales d'utilisation");

				if (!ModelState.IsValid)
					throw new ArgumentException("Modèle invalide");

				Utilisateur nouvelUtilisateur = form.ToBLL();

				int utilisateurId = _utilisateurService.Insert(nouvelUtilisateur);

				return RedirectToAction(nameof(Details), new { id = utilisateurId });
			}
			catch
			{
				return View();
			}
		}

		// GET: UtilisateurController/Edit/5
		public ActionResult Edit(int id)
		{
			try
			{
				Utilisateur utilisateur = _utilisateurService.Get(id);
				UtilisateurEditForm model = utilisateur.ToEditForm();
				return View(model);
			}
			catch (Exception)
			{
				return RedirectToAction("Error", "Home");
			}
		}

		// POST: UtilisateurController/Edit/5


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

namespace UI.Controllers
{
	public static class UtilisateurExtensions
	{
		public static UtilisateurEditForm ToEditForm(this Utilisateur utilisateur)
		{
			if (utilisateur == null)
				throw new ArgumentOutOfRangeException(nameof(utilisateur));

			return new UtilisateurEditForm
			{
				Email = utilisateur.Email,
				Pseudo = utilisateur.Pseudo
			};
		}
	}
}
