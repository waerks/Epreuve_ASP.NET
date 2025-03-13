using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using BLL.Services;
using BLL.Entities;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var jeuService = new JeuService();

			var jeux = jeuService.Get().ToList();

			var top10Jeux = jeux.Take(10).ToList();

			return View(top10Jeux);
		}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
