using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogMvcApp.Models;

namespace BlogMvcApp.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext();

        public ActionResult List(int? id, string q)
        {
            var blogs = db.Blogs
                             .Where(i => i.Approval == true)
                             .Select(i => new BlogModel()
                             {
                                 Id = i.Id,
                                 Header = i.Header.Length > 100 ? i.Header.Substring(0, 100) + "..." : i.Header,
                                 Description = i.Description,
                                 UploadDate = i.UploadDate,
                                 HomePage = i.HomePage,
                                 Approval = i.Approval,
                                 İmage = i.İmage,
                                 CategoryId = i.CategoryId
                             }).AsQueryable();

            if (string.IsNullOrEmpty("q") == false)
            {
                blogs = blogs.Where(i => i.Header.Contains(q) || i.Description.Contains(q));
            }

            if (id != null)
            {
                blogs = blogs.Where(i => i.CategoryId == id);
            }

            return View(blogs.ToList());
        }

        // GET: Blog
        public ActionResult Index()
        {
            var bloglar = db.Blogs.Include(b => b.Category).OrderByDescending(i => i.UploadDate);
            return View(bloglar.ToList());
        }

        // GET: Blog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Header,Description,İmage,Content,CategoryId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.UploadDate = DateTime.Now;

                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Header,Description,İmage,Content,Approval,HomePage,CategoryId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Blogs.Find(blog.Id);
                if (entity != null)
                {
                    entity.Header = blog.Header;
                    entity.Description = blog.Description;
                    entity.İmage = blog.İmage;
                    entity.Content = blog.Content;
                    entity.Approval = blog.Approval;
                    entity.HomePage = blog.HomePage;
                    entity.CategoryId = blog.CategoryId;

                    db.SaveChanges();

                    TempData["Blog"] = entity;

                    return RedirectToAction("Index");
                }
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blog blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
