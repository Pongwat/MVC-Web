using Microsoft.AspNetCore.Mvc;

namespace BasicApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
