using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Sites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}
