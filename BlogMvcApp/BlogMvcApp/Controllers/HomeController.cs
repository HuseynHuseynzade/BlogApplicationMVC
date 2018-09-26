using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                                .Where(i => i.Approval == true && i.HomePage == true)
                                .Select(i => new BlogModel()
                                {
                                    Id = i.Id,
                                    Header = i.Header.Length > 100 ? i.Header.Substring(0, 100) + "..." : i.Header,
                                    Description = i.Description,
                                    UploadDate = i.UploadDate,
                                    HomePage = i.HomePage,
                                    Approval = i.Approval,
                                    İmage = i.İmage
                                });                              


            return View(blogs.ToList());
        }
    }
}