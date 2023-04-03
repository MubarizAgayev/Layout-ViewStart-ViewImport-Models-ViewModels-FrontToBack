using Microsoft.AspNetCore.Mvc;
using Practise.Models;
using Practise.ViewModels.Home;
using Practise.ViewModels.Product;

namespace Practise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["names"] = new string[] { "Elcan", "Roya", "Aqshin" };

            //ViewBag.numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            //TempData["surname"] = "Qurbanov";

            //return RedirectToAction(nameof(Detail));

            //string name = "Xaker";
            //return View((object)name);

            Student stu1 = new()
            {
                Id = 1,
                FullName = "Pervin Rehimli",
                Age = 26
            };
            Student stu2 = new()
            {
                Id = 2,
                FullName = "Mirze Basirli",
                Age = 26
            };
            Student stu3 = new()
            {
                Id = 3,
                FullName = "Ali Talibov",
                Age = 26
            };
            //ViewBag.address = "Sumqayit";
            List<Student> students = new List<Student>() { stu1, stu2, stu3 };
            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Count = 50,
                Price = 200,
                Description = "Description"
            };
            ProductVM productVM = new()
            {
                Name = product.Name,
                Price = product.Price
            };
            HomeVM model = new()
            {
                Students = students,
                Products = productVM
            };

            return View(model);
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
