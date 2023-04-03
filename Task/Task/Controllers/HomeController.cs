using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}