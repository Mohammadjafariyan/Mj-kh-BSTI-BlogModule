using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRMVCChat.Models.HelpDesk;
using SignalRMVCChat.Models.weblog;


namespace WeblogModule.Controllers
{
        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class EditorController : Controller
    {
 
        // GET: Customer/Editor
        public ActionResult Index()
        {

            using (var db = new BigPardakht.Data.ApplicationDbContext())
            {
                if (db == null)
                {
                    throw new Exception("db is null ::::::");
                }

                var blogList = db.Blogs.Include(s=>s.Category).Select(b => new
                {
                    Title = b.Title,
                    Id = b.Id,
                    Type=b.Type,
                    Category = b.Category

                }).ToList().Select(b => new BlogViewModel
                {
                    Title = b.Title,
                    Id = b.Id,
                    Type = b.Type,
                    Category = b.Category
                }).ToList();
                return View(blogList);

            }

        }

        public ActionResult Detail(long blogId)
        {
            if (blogId == 0)
            {
                return View(new Blog());

            }
            else
            {
                using (var db = new BigPardakht.Data.ApplicationDbContext())
                {
                    if (db == null)
                    {
                        throw new Exception("db is null ::::::");
                    }

                    var blog = db.Blogs.Find(blogId);
                    if (blog == null)
                    {
                        throw new Exception("مطلب مورد نظر یافت نشد");
                    }
                    return View(blog);

                }
            }
        }

        [HttpPost]
        public ActionResult Save(Blog blog)
        {
            using (var db = new BigPardakht.Data.ApplicationDbContext())
            {
                if (db == null)
                {
                    throw new Exception("db is null ::::::");
                }

                if (blog.Id == 0)
                {
                    db.Blogs.Add(blog);
                }
                else
                {
                    var record = db.Blogs.Find(blog.Id);

                    db.Entry(record).CurrentValues.SetValues(blog);

                    db.Entry(record).State = EntityState.Modified;

                }
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }


        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class BlogViewModel : Blog
    {
    }
}