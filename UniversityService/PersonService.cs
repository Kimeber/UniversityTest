using Common;
using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityService
{
    public class PersonService
    {
        public static PersonDTO GetPerson(int PersonID)
        {
            using(ModelContainer context = new ModelContainer())
            {
                Person current = context.Person
                    .Include("Student")
                    .Include("Student.ClassStudent")
                    .Include("Teacher")
                    .Where(x => x.Id == PersonID)
                    .SingleOrDefault();
                if (current == null)
                {
                    return null;
                }
                Student personStudent = current.Student.FirstOrDefault();
                if (personStudent != null && personStudent.Grade == null)
                {
                    int studentId = current.Student.FirstOrDefault().Id;
                    Student student = context.Student.Where(x => x.Id == studentId).FirstOrDefault();
                    decimal Grade = Functions.CalculateGrade(current.Student.FirstOrDefault().ClassStudent.ToList());
                    student.Grade = Grade;
                    personStudent.Grade = Grade;
                    context.SaveChanges();
                }
                return PersonDTO.Map(current);
            }
        }

        public static bool CreatePerson(PersonDTO personDTO)
        {
            try
            {
                using (ModelContainer context = new ModelContainer())
                {
                    Person person = PersonDTO.Map(personDTO);
                    context.Person.Add(person);
                    context.SaveChanges();
                    if(personDTO.Type == 1)
                    {
                        Teacher teacher = PersonDTO.MapTeacher(personDTO, person.Id);
                        context.Teacher.Add(teacher);
                    }
                    else if (personDTO.Type == 2)
                    {
                        Student student = PersonDTO.MapStudent(personDTO, person.Id);
                        context.Student.Add(student);
                    }
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeletePerson(int id)
        {
            try
            {
                using (ModelContainer context = new ModelContainer())
                {
                    Person current = context.Person
                        .Where(x => x.Id == id)
                        .SingleOrDefault();
                    if (current == null)
                    {
                        return false;
                    }
                    if (current.Student.Count > 0)
                    {
                        int studentID = current.Student.FirstOrDefault().Id;
                        Student student = context.Student.Where(x => x.Id == studentID).FirstOrDefault();
                        context.Student.Remove(student);
                    }
                    if (current.Teacher.Count > 0)
                    {
                        int teacherID = current.Teacher.FirstOrDefault().Id;
                        Teacher teacher = context.Teacher.Where(x => x.Id == teacherID).FirstOrDefault();
                        context.Teacher.Remove(teacher);
                    }
                    context.Person.Remove(current);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static List<PersonDTO> GetAllPersons()
        {
            using (ModelContainer context = new ModelContainer())
            {
                List<PersonDTO> list = new List<PersonDTO>();
                var persons = context.Person.ToList();
                foreach (Person person in persons)
                {
                    list.Add(PersonDTO.Map(person));
                }
                return list;
            }
        }

        public static bool EditPerson(int id, PersonDTO person)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Person current = context.Person
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (current == null)
                {
                    return false;
                }
                current.Name = person.Name;
                current.Birthday = person.BirthDay;
                if(person.Type == 1)
                {
                    Teacher teacher = current.Teacher.FirstOrDefault();
                    teacher.Salary = person.Salary;
                }
                if(person.Type == 2)
                {
                    Student student = current.Student.FirstOrDefault();
                    student.CourseID = person.CourseID ?? 0;
                    student.Grade = person.Grade;
                    student.nReg = person.NReg ?? 0;
                }
                context.SaveChanges();
                return true;
            }
        }
    }
}
