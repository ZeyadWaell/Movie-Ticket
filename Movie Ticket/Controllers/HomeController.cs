using Infrastraction.Entites;
using Infrastraction.Interface;
using Microsoft.AspNetCore.Mvc;
using Movie_Ticket.Models;
using System.Diagnostics;

namespace Movie_Ticket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUniteOfWork _uniteOfWork;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IUniteOfWork uniteOfWork, ILogger<HomeController> logger)
        {
            _uniteOfWork = uniteOfWork;
            _logger = logger;
        }
   

        public IActionResult Index()
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