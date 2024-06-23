using CoursesLabTask.DTOs;
using CoursesLabTask.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoursesLabTask.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            LabTaskEntities db = new LabTaskEntities();
            var data = db.Courses.ToList();
            var converted = Convert(data);
            return View(converted);
        }

        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(CourseDTO c)
        {
            LabTaskEntities db = new LabTaskEntities();
            if (ModelState.IsValid)
            {
                var cr = Convert(c);
                db.Courses.Add(cr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult EditCourse(int id)
        {
            LabTaskEntities db = new LabTaskEntities();
            var exobj = db.Courses.Find(id);
            var convertedData = Convert(exobj);
            return View(convertedData);
        }

        [HttpPost]
        public ActionResult EditCourse(CourseDTO c)
        {
            LabTaskEntities db = new LabTaskEntities();

            var exobj = db.Courses.Find(c.Id);
            exobj.Title = c.Title;
            exobj.CreditHr = c.CreditHr;
            exobj.Type = c.Type;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteCourse(CourseDTO c)
        {
            LabTaskEntities db = new LabTaskEntities();
            var exobj = db.Courses.Find(c.Id);

            if(exobj != null)
            {
                db.Courses.Remove(exobj);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public static CourseDTO Convert(Cours c)
        {
            return new CourseDTO()
            {
                Id = c.Id,
                Title = c.Title,
                CreditHr = c.CreditHr,
                Type = c.Type
            };
        }

        public static Cours Convert(CourseDTO c)
        {
            return new Cours()
            {
                Id = c.Id,
                Title = c.Title,
                CreditHr = c.CreditHr,
                Type = c.Type
            };
        }

        public List<CourseDTO> Convert(List<Cours> courses)
        {
            var List = new List<CourseDTO>();
            foreach (var c in courses)
            {
                var cr = Convert(c);
                List.Add(cr);
            }
            return List;
        }
    }
}