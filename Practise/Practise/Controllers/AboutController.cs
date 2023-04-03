using Microsoft.AspNetCore.Mvc;

namespace Practise.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
