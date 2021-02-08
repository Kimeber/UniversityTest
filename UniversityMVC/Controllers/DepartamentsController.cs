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
    public class DepartamentsController : Controller
    {
        // GET: Departaments
        public ActionResult Index()
        {
            try
            {
                var list = DepartamentService.GetAllDepartaments();
                return View(list);
            }
            catch
            {
                return View();
            }
        }

        // GET: Departaments/Details/5
        public ActionResult Details(int id)
        {
            DepartamentViewModel departament = DepartamentDTO.MapToView(DepartamentService.GetDepartament(id));
            return View(departament);
        }

        // GET: Departaments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departaments/Create
        [HttpPost]
        public ActionResult Create(DepartamentViewModel model)
        {
            try
            {
                bool result = DepartamentService.CreateDepartament(DepartamentDTO.Map(model));
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

        // GET: Departaments/Edit/5
        public ActionResult Edit(int id)
        {
            DepartamentViewModel departament = DepartamentDTO.MapToView(DepartamentService.GetDepartament(id));
            return View(departament);
        }

        // POST: Departaments/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DepartamentViewModel model)
        {
            try
            {
                bool result = DepartamentService.EditDepartament(id, DepartamentDTO.Map(model));
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

        // GET: Departaments/Delete/5
        public ActionResult Delete(int id)
        {
            bool result = DepartamentService.DeleteDepartament(id);
            return RedirectToAction("Index");
        }
    }
}
