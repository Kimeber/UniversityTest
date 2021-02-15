using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using ViewModels;

namespace DTO
{
    public class SubjectDTO
    {
        public int ID { get; set; }

        public int CourseID { get; set; }

        public int TeacherID { get; set; }

        public decimal Credits { get; set; }

        public decimal Average { get; set; }

        public string Name { get; set; }

        public Course Course { get; set; }

        public Teacher Teacher { get; set; }

        public List<ClassStudentDTO> ClassStudents { get; set; }


        public static Subject Map(SubjectDTO subject)
        {
            return new Subject
            {
                Id = subject.ID,
                CourseId = subject.CourseID,
                TeacherId = subject.TeacherID,
                Credits = subject.Credits,
                Name = subject.Name
            };
        }

        public static SubjectDTO Map(Subject subject)
        {
            List<ClassStudentDTO> list = new List<ClassStudentDTO>();
            foreach (var item in subject.ClassStudent)
            {
                list.Add(ClassStudentDTO.Map(item));
            }

            return new SubjectDTO
            {
                ID = subject.Id,
                TeacherID = subject.TeacherId,
                CourseID = subject.CourseId,
                Credits = subject.Credits,
                Name = subject.Name,
                Course = subject.Course,
                Teacher = subject.Teacher,
                ClassStudents = list,
                Average = Common.Functions.CalculateAverage(subject.ClassStudent.ToList())
            };
        }

        public static SubjectDTO Map(SubjectViewModel subject)
        {
            return new SubjectDTO
            {
                ID = subject.SubjectID,
                CourseID = subject.CourseID,
                TeacherID = subject.TeacherID,
                Credits = subject.Credits,
                Name = subject.Name
                //TODO Missing students
            };
        }

        public static SubjectViewModel MapToView(SubjectDTO subject)
        {
            if (subject == null)
            {
                return null;
            }
            List<ClassStudentViewModel> list = new List<ClassStudentViewModel>();
            foreach (var item in subject.ClassStudents)
            {
                list.Add(ClassStudentDTO.MapToView(item));
            }
            return new SubjectViewModel
            {
                SubjectID = subject.ID,
                TeacherID = subject.TeacherID,
                CourseID = subject.CourseID,
                Credits = subject.Credits,
                Course = subject.Course?.Title,
                Teacher = subject.Teacher?.Person?.Name,
                Name = subject.Name,
                ClassStudents = list,
                Average = Common.Functions.CalculateAverage(list)
            };
        }
    }
}
