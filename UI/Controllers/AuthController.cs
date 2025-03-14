using Microsoft.AspNetCore.Mvc;
using BLL.Entities;
using Common.Repositories;
using UI.Models.Auth;

namespace UI.Controllers
{
	public class AuthController : Controller
	{
		private IUtilisateurService<BLL.Entities.Utilisateur> _utilisateurService;

		public AuthController(IUtilisateurService<Utilisateur> utilisateurService)
		{
			_utilisateurService = utilisateurService;
		}

		public ActionResult Index()
		{
			return RedirectToAction(nameof(Login));
		}

		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(AuthloginForm form)
		{
			if (!ModelState.IsValid)
				return View(form);
			int utilisateurId = _utilisateurService.CheckPassword(form.Email, form.MotDePasse);
			if (utilisateurId == 0)
			{
				ModelState.AddModelError(nameof(form.Email), "Email ou mot de passe incorrect");
				return View(form);
			}
			HttpContext.Session.SetInt32("UtilisateurId", utilisateurId);
			return RedirectToAction("Details", "Utilisateur", new {id = utilisateurId});
		}
	}
}
