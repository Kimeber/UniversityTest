using System;
using System.Collections.Generic;
using DataLayer;
using ViewModels;

namespace DTO
{
    public class SubjectDTO
    {
        public int ID { get; set; }

        public int CourseID { get; set; }

        public Course Course { get; set; }

        public int TeacherID { get; set; }

        public Teacher Teacher { get; set; }

        public string Name { get; set; }

        public decimal Credits { get; set; }

        public List<Models.SubjectStudent> Students { get; set; }

        public static Subject Map(SubjectDTO subject)
        {
            return new Subject
            {
                Id = subject.ID,
                CourseId = subject.CourseID,
                TeacherId = subject.TeacherID,
                Course = subject.Course,
                Teacher = subject.Teacher,
                Name = subject.Name,
                Credits = subject.Credits
                //TODO Missing students
            };
        }

        public static SubjectDTO Map(Subject subject)
        {
            return new SubjectDTO
            {
                ID = subject.Id,
                TeacherID = subject.TeacherId,
                CourseID = subject.CourseId,
                Course = subject.Course,
                Teacher = subject.Teacher,
                Name = subject.Name,
                Credits = subject.Credits
                //TODO Missing students
            };
        }

        public static SubjectDTO Map(SubjectViewModel subject)
        {
            return new SubjectDTO
            {
                ID = subject.SubjectID,
                CourseID = subject.CourseID,
                TeacherID = subject.TeacherID,
                Name = subject.Name,
                Credits = subject.Credits
                //TODO Missing students
            };
        }

        public static SubjectViewModel MapToView(SubjectDTO subject)
        {
            if (subject == null)
            {
                return null;
            }
            return new SubjectViewModel
            {
                SubjectID = subject.ID,
                TeacherID = subject.TeacherID,
                CourseID = subject.CourseID,
                Name = subject.Name,
                Teacher = subject?.Teacher?.Person?.Name,
                Credits = subject.Credits
                //TODO Missing students
            };
        }
    }
}
