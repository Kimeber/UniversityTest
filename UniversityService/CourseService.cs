using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityService
{
    public class CourseService
    {
        public static CourseDTO GetCourse(int CourseID)
        {
            using(ModelContainer context = new ModelContainer())
            {
                Course current = context.Course
                    .Include("Departament")
                    .Where(x => x.Id == CourseID)
                    .SingleOrDefault();
                if (current == null)
                {
                    return null;
                }
                return CourseDTO.Map(current);
            }
        }

        public static bool CreateCourse(CourseDTO courseDTO)
        {
            try
            {
                using (ModelContainer context = new ModelContainer())
                {
                    Course course = CourseDTO.Map(courseDTO);
                    context.Course.Add(course);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteCourse(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Course current = context.Course
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (current == null){
                    return false;
                }
                context.Course.Remove(current);
                context.SaveChanges();
                return true;
            }
        }

        public static List<CourseDTO> GetAllCourses()
        {
            using (ModelContainer context = new ModelContainer())
            {
                List<CourseDTO> list = new List<CourseDTO>();
                var courses = context.Course.ToList();
                foreach (Course course in courses)
                {
                    list.Add(CourseDTO.Map(course));
                }
                return list;
            }
        }

        public static bool EditCourse(int id, CourseDTO course)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Course old = context.Course
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (old == null)
                {
                    return false;
                }
                old.Credits = course.Credits;
                old.Title = course.Title;
                old.DepartamentId = course.DepartamentID;
                context.SaveChanges();
                return true;
            }
        }
    }
}
