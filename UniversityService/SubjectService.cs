using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityService
{
    public class SubjectService
    {
        public static SubjectDTO GetSubject(int subjectID)
        {
            using(ModelContainer context = new ModelContainer())
            {
                Subject current = context.Subject
                    .Include("Course")
                    .Include("Teacher")
                    .Include("Teacher.Person")
                    .Where(x => x.Id == subjectID)
                    .SingleOrDefault();
                if (current == null)
                {
                    return null;
                }
                return SubjectDTO.Map(current);
            }
        }

        public static bool CreateSubject(SubjectDTO subjectDTO)
        {
            try
            {
                using (ModelContainer context = new ModelContainer())
                {
                    Subject subject = SubjectDTO.Map(subjectDTO);
                    context.Subject.Add(subject);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteSubject(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Subject current = context.Subject
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (current == null){
                    return false;
                }
                context.Subject.Remove(current);
                context.SaveChanges();
                return true;
            }
        }

        public static List<SubjectDTO> GetAllSubjects()
        {
            using (ModelContainer context = new ModelContainer())
            {
                List<SubjectDTO> list = new List<SubjectDTO>();
                var subjects = context.Subject
                    .Include("Course")
                    .Include("Teacher")
                    .Include("Teacher.Person")
                    .ToList();
                foreach (Subject subject in subjects)
                {
                    list.Add(SubjectDTO.Map(subject));
                }
                return list;
            }
        }

        public static bool EditSubject(int id, SubjectDTO subject)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Subject old = context.Subject
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (old == null)
                {
                    return false;
                }
                old.CourseId = subject.CourseID;
                old.TeacherId = subject.TeacherID;
                old.Credits = subject.Credits;
                old.Name = subject.Name;
                context.SaveChanges();
                return true;
            }
        }
    }
}
