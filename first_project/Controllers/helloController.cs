using Microsoft.AspNetCore.Mvc;

namespace first_project.Controllers
{
    public class helloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
