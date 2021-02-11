using System;
using System.ComponentModel.DataAnnotations;
using DataLayer;
using ViewModels;

namespace DTO
{
    public class CourseDTO
    {
        public int ID { get; set; }
        public decimal Credits { get; set; }
        public int DepartamentID { get; set; }
        public string Title { get; set; }

        public Departament Departament { get; set; }

        public static Course Map(CourseDTO courseDTO)
        {
            return new Course
            {
                Credits = courseDTO.Credits,
                DepartamentId = courseDTO.DepartamentID,
                Id = courseDTO.ID,
                Title = courseDTO.Title,
                Departament = courseDTO.Departament
            };
        }

        public static CourseDTO Map(Course course)
        {
            return new CourseDTO
            {
                Credits = course.Credits,
                DepartamentID = course.DepartamentId,
                Departament = course.Departament,
                ID = course.Id,
                Title = course.Title
            };
        }

        public static CourseDTO Map(CourseViewModel course)
        {
            return new CourseDTO
            {
                ID = course.CourseID,
                DepartamentID = course.DepartamentID,
                Credits = course.Credits,
                Title = course.Title
            };
        }

        public static CourseViewModel MapToView(CourseDTO course)
        {
            if (course == null)
            {
                return null;
            }
            return new CourseViewModel
            {
                CourseID = course.ID,
                Credits = course.Credits,
                DepartamentID = course.DepartamentID,
                Title = course.Title
            };
        }
    }
}
