﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityService;
using ViewModels;

namespace UniversityMVC.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            try
            {
                var list = CourseService.GetAllCourses();
                return View(list);
            }
            catch
            {
                return View();
            }
        }

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            CourseViewModel course = CourseDTO.MapToView(CourseService.GetCourse(id));
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        public ActionResult Create(CourseViewModel model)
        {
            try
            {
                bool result = CourseService.CreateCourse(CourseDTO.Map(model));
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

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            CourseViewModel course = CourseDTO.MapToView(CourseService.GetCourse(id));
            return View(course);
        }

        // POST: Courses/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CourseViewModel model)
        {
            try
            {
                bool result = CourseService.EditCourse(id, CourseDTO.Map(model));
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

        // GET: Courses/Delete/5
        public ActionResult Delete(int id)
        {
            bool result = CourseService.DeleteCourse(id);
            return RedirectToAction("Index");
        }

        public ActionResult List()
        {
            try
            {
                var list = CourseService.GetAllCourses();
                return View(list);
            }
            catch
            {
                return View();
            }
        }
    }
}
