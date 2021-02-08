using DataLayer;
using DTO;
using System;
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
                    .Include("Course.Departament")
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
                return true;
            }
        }
    }
}
