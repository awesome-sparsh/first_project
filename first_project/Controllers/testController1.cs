using Microsoft.AspNetCore.Mvc;

namespace first_project.Controllers
{
    public class testController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
