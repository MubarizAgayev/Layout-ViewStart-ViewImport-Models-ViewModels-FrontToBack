using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
