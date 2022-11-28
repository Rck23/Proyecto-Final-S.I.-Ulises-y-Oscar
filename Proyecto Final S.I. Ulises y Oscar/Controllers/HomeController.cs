using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Final_S.I._Ulises_y_Oscar.Models;

namespace Proyecto_Final_S.I._Ulises_y_Oscar.Controllers
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
			return View();
		}

		public IActionResult APrivacidad()
		{
			return View();
		}

		public IActionResult ResponLegal()
		{
			return View();
		}
		public IActionResult NormasyEstandares()
		{
			return View();
		}

		public IActionResult Seguridad()
		{
			return View();
		}

		public IActionResult Cifrado()
		{
			return View();
		}

		public IActionResult Integridad()
		{
			return View();
		}

		public IActionResult Criptografia()
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