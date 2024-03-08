using System.Diagnostics;
using KashanExpress.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Store.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
        [Route("/")]
        public IActionResult Index()
		{
			return View();
		}
		[Route("/About")]
		public IActionResult About()
		{
			return View();
		}
        [Route("/Products")]
        public IActionResult Products()
        {
            return View();
        }

        [Route("/ContactUs")]
		[Route("/Contact")]
        public IActionResult Contact_us()
        {
            return View();
        }
        
             [Route("/Single_Product")]
        public IActionResult Single_product()
        {
            return View();
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