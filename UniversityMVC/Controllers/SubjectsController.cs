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
    public class SubjectsController : Controller
    {
        // GET: Subjects
        public ActionResult Index()
        {
            try { 
                var list = SubjectService.GetAllSubjects();
                return View(list);
            }
            catch
            {
                return View();
            }
        }

        // GET: Subjects/Details/5
        public ActionResult Details(int id)
        {
            SubjectViewModel departament = SubjectDTO.MapToView(SubjectService.GetSubject(id));
            return View(departament);
        }

        // GET: Subjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subjects/Create
        [HttpPost]
        public ActionResult Create(SubjectViewModel model)
        {
            try
            {
                bool result = SubjectService.CreateSubject(SubjectDTO.Map(model));
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

        // GET: Subjects/Edit/5
        public ActionResult Edit(int id)
        {
            SubjectViewModel departament = SubjectDTO.MapToView(SubjectService.GetSubject(id));
            return View(departament);
        }

        // POST: Subjects/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SubjectViewModel model)
        {
            try
            {
                bool result = SubjectService.EditSubject(id, SubjectDTO.Map(model));
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

    // GET: Subjects/Delete/5
        public ActionResult Delete(int id)
        {
            bool result = SubjectService.DeleteSubject(id);
            return RedirectToAction("Index");
        }
    }
}
