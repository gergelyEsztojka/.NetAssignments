using Microsoft.AspNetCore.Mvc;

namespace FirstEntityFrameworkCoreProject.Controllers.Page
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}