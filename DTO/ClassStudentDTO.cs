using DataLayer;
using System;
using ViewModels;

namespace DTO
{
    public class ClassStudentDTO
    {
        public int ClassStudentID { get; set; }

        public int StudentID { get; set; }

        public string Student { get; set; }

        public int SubjectId { get; set; }

        public decimal? Grade { get; set; }


        public static ClassStudentDTO Map(ClassStudent classStudent)
        {
            return new ClassStudentDTO
            {
                ClassStudentID = classStudent.Id,
                StudentID = classStudent.StudentId,
                Student = classStudent.Student?.Person?.Name,
                SubjectId = classStudent.SubjectId,
                Grade = classStudent.Grade
            };
        }

        public static ClassStudentViewModel MapToView(ClassStudentDTO classStudent)
        {
            return new ClassStudentViewModel
            {
                ClassStudentID = classStudent.ClassStudentID,
                Grade = classStudent.Grade,
                Student = classStudent.Student,
                StudentID = classStudent.StudentID
            };
        }
    }
}