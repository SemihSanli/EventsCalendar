using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventCalendar.Context;
using EventCalendar.Entities;
using System.Data.Entity;

namespace EventCalendar.Controllers
{
    public class EventController : Controller
    {
        private EventContext db = new EventContext();
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
        // GET: Event/EventList
        public ActionResult EventList()
        {
            var events = db.Events.Include("Category").ToList();
            return View(events);
        }

        // GET: Event/GetEvents
        public JsonResult GetEvents()
        {
            var events = db.Events.Include(e => e.Category).ToList();
            var result = events.Select(e => new {
                id = e.EventId,
                title = e.Title,
                start = e.StartDate.ToString("s"),
                end = e.EndDate.ToString("s"),
                categoryId = e.CategoryId,
                color = e.Category != null ? e.Category.Color : "#3788d8"
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // GET: Event/GetLastEvents
        public JsonResult GetLastEvents()
        {
            var events = db.Events.Include("Category").OrderByDescending(e => e.EventId).Take(5).ToList();
            var result = events.Select(e => new {
                id = e.EventId,
                title = e.Title,
                start = e.StartDate.ToString("s"),
                end = e.EndDate.ToString("s"),
                categoryId = e.CategoryId,
                color = e.Category != null ? e.Category.Color : "#3788d8"
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // POST: Event/AddEvent
        [HttpPost]
        public JsonResult AddEvent(string title, DateTime start, DateTime end, int categoryId)
        {
            var ev = new Event
            {
                Title = title,
                StartDate = start,
                EndDate = end,
                CategoryId = categoryId
            };
            db.Events.Add(ev);
            db.SaveChanges();
            return Json(new { success = true, eventId = ev.EventId });
        }

        // GET: Event/UpdateEventDate/{id}
        public ActionResult UpdateEventDate(int id)
        {
            var ev = db.Events.Find(id);
            if (ev == null)
                return HttpNotFound();
            ViewBag.Categories = db.Categories.ToList();
            return View(ev);
        }

        // POST: Event/UpdateEventDate (Takvim sürükle-bırak için)
        [HttpPost]
        public JsonResult UpdateEventDate(int id, string start, string end)
        {
            var ev = db.Events.Find(id);
            if (ev == null)
                return Json(new { success = false, message = "Event not found" });
            DateTime startDate, endDate;
            if (!DateTime.TryParse(start, out startDate) || !DateTime.TryParse(end, out endDate))
                return Json(new { success = false, message = "Tarih formatı hatalı" });
            ev.StartDate = startDate;
            ev.EndDate = endDate;
            db.Entry(ev).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json(new { success = true });
        }

        // POST: Event/DeleteEvent
        [HttpPost]
        public JsonResult DeleteEvent(int id)
        {
            var ev = db.Events.Find(id);
            if (ev == null)
                return Json(new { success = false, message = "Event not found" });
            db.Events.Remove(ev);
            db.SaveChanges();
            return Json(new { success = true });
        }
    }
}