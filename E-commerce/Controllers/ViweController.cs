using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class ViweController : Controller
    {
        public IActionResult Index()
        {
            List<string> List = new List<string>() { "assem", "ahmed", "mohmed", "karem" };
            return View(model: List);
        }
    }
}
