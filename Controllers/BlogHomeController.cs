using Microsoft.AspNetCore.Mvc;

namespace BlogModule.Controllers
{
    public class BlogHomeController:Controller
    {
        public IActionResult Index()
        {

            return View("Index");
        }
    }
}