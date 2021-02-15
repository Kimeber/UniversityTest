using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityService;
using ViewModels;

namespace UniversityMVC.Controllers
{
    public class PersonsController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            try
            {
                var list = PersonService.GetAllPersons();
                return View(list);
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            PersonViewModel person = PersonDTO.MapToView(PersonService.GetPerson(id));
            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            PersonViewModel model = new PersonViewModel();
            ViewBag.Types = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Text = "Choose...", Value = "0" },
                    new SelectListItem { Text = "Teacher", Value = "1" },
                    new SelectListItem { Text = "Student", Value = "2" },
                }, "Value", "Text");

            var courses = CourseService.GetAllCourses().OrderBy(x => x.Title);
            List<SelectListItem> coursesItems = new List<SelectListItem>
            {
                new SelectListItem { Text = "Choose...", Value = "0" }
            };
            foreach (var item in courses)
            {
                coursesItems.Add(new SelectListItem { Text = item.Title, Value = item.ID.ToString() });
            }
            ViewBag.Courses = new SelectList(coursesItems, "Value", "Text");
            return View(model);
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonViewModel model)
        {
            try
            {
                bool result = PersonService.CreatePerson(PersonDTO.Map(model));
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            PersonViewModel person = PersonDTO.MapToView(PersonService.GetPerson(id));
            var courses = CourseService.GetAllCourses().OrderBy(x => x.Title);
            List<SelectListItem> coursesItems = new List<SelectListItem>
            {
                new SelectListItem { Text = "Choose...", Value = "0" }
            };
            foreach (var item in courses)
            {
                coursesItems.Add(new SelectListItem { Text = item.Title, Value = item.ID.ToString() });
            }
            ViewBag.Courses = new SelectList(coursesItems, "Value", "Text");
            return View(person);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PersonViewModel model)
        {
            try
            {
                bool result = PersonService.EditPerson(id, PersonDTO.Map(model));
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            bool result = PersonService.DeletePerson(id);
            return RedirectToAction("Index");
        }
    }
}
