using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SignalRMVCChat.Models.weblog;


namespace BlogModule.Controllers
{
        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class BlogController : Controller
    {
        private readonly BigPardakht.Data.ApplicationDbContext _applicationDbContext;

        public BlogController(BigPardakht.Data.ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // GET
        public IActionResult Index(BlogType type)
        {
            var list = _applicationDbContext.Blogs.Where(b=>b.Type==type).ToList();

            return View("Index",list);
        }
    }
}