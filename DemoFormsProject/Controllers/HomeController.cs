using Microsoft.AspNetCore.Mvc;

namespace DemoFormsProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
