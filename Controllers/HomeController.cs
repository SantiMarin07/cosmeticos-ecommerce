using Microsoft.AspNetCore.Mvc;

namespace CosmeticosEcommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
