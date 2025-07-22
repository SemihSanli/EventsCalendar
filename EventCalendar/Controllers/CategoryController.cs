using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventCalendar.Context;
using EventCalendar.Entities;

namespace EventCalendar.Controllers
{
    public class CategoryController : Controller
    {
        private EventContext db = new EventContext();
        // GET: Category
        public ActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View(categories);
        }


        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCategory(string Name, string Color)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Color))
            {
                ModelState.AddModelError("", "Name and Color are required.");
                return View();
            }
            db.Categories.Add(new Category { Name = Name, Color = Color });
            db.SaveChanges();
            return RedirectToAction("Index", "Event");
        }

        // GET: Category/GetCategories
        public JsonResult GetCategories()
        {
            var categories = db.Categories.ToList();
            var result = categories.Select(c => new {
                id = c.CategoryId,
                name = c.Name,
                color = c.Color
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // GET: Category/UpdateCategory/{id}
        public ActionResult UpdateCategory(int id)
        {
            var cat = db.Categories.Find(id);
            if (cat == null)
                return HttpNotFound();
            return View(cat);
        }

        // POST: Category/UpdateCategory
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateCategory(EventCalendar.Entities.Category model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var cat = db.Categories.Find(model.CategoryId);
            if (cat == null)
                return HttpNotFound();
            cat.Name = model.Name;
            cat.Color = model.Color;
            db.Entry(cat).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Category/DeleteCategory
        [HttpPost]
        public JsonResult DeleteCategory(int id)
        {
            var cat = db.Categories.Find(id);
            if (cat == null)
                return Json(new { success = false, message = "Kategori bulunamadı" });
            db.Categories.Remove(cat);
            db.SaveChanges();
            return Json(new { success = true });
        }
        
    }
}