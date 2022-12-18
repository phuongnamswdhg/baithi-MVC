using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult welcome(string name , int numtime = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Numtime"] = numtime;
            return View();
        }
    }
}
