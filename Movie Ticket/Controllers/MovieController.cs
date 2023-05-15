using Microsoft.AspNetCore.Mvc;

namespace Movie_Ticket.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
