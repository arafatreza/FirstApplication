using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationTest.Models;
using WebApplicationTest.Repository;
using WebApplicationTest.Service;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        private IWelcomeService _welcomeService;
        private readonly ILogger<HomeController> _logger;
        public HomeController(IWelcomeService welcomeService)
        {
            _welcomeService = welcomeService;
        }
        public IActionResult Index()
        {

            var model = _welcomeService.GetWelcomeModelService();
            return View(model);
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
