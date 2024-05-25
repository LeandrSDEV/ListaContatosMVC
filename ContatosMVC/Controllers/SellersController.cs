using Microsoft.AspNetCore.Mvc;

namespace ContatosMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
