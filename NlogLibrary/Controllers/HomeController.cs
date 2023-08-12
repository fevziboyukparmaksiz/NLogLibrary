using Microsoft.AspNetCore.Mvc;
using NlogLibrary.Models;
using System.Diagnostics;

namespace NlogLibrary.Controllers
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
            int value1 = 5;
            int value2 = 0;
            int result;
            try
            {
                result = value1 / value2;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

            }

            _logger.LogInformation("Hello, this is the index!");
            _logger.LogWarning("Warning");
            _logger.LogError("Error");
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