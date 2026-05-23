using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ME : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GETlIST()
        {
            return View();
        }
    }
}
