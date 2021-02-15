using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DataLayer;
using ViewModels;

namespace DTO
{
    public class PersonDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime? BirthDay { get; set; }
        //Student
        public int? NReg { get; set; }
        public int? CourseID { get; set; }
        public decimal? Grade { get; set; }

        //Teacher
        public decimal? Salary { get; set; }


        public static Person Map(PersonDTO personDTO)
        {
            return new Person
            {
                Id = personDTO.ID,
                Birthday = personDTO.BirthDay,
                Name = personDTO.Name
            };
        }

        public static PersonDTO Map(Person person)
        {
            var student = person.Student.FirstOrDefault();
            var teacher = person.Teacher.FirstOrDefault();
            var type = teacher != null ? 1 : student != null ? 2 : 0;
            return new PersonDTO
            {
                ID = person.Id,
                Name = person.Name,
                BirthDay = person.Birthday,
                Type = type,
                CourseID = student?.CourseID,
                Grade = student?.Grade,
                NReg = student?.nReg,
                Salary = teacher?.Salary
            };
        }

        public static PersonDTO Map(PersonViewModel person)
        {
            return new PersonDTO
            {
                ID = person.Id,
                Name = person.Name,
                BirthDay = person.Birthday,
                Type = person.Type,
                NReg = person.NReg,
                CourseID = person.CourseId,
                Salary = person.Salary,
                Grade = person.Grade
            };
        }

        public static Student MapStudent(PersonDTO personDTO, int id)
        {
            return new Student
            {
                PersonId = id,
                CourseID = personDTO.CourseID ?? 0,
                nReg = personDTO.NReg ?? 0,
                Grade = personDTO.Grade
            };
        }

        public static Teacher MapTeacher(PersonDTO personDTO, int id)
        {
            return new Teacher
            {
                PersonId = id,
                Salary = personDTO.Salary
            };
        }

        public static PersonViewModel MapToView(PersonDTO person)
        {
            if (person == null)
            {
                return null;
            }
            return new PersonViewModel
            {
                Id = person.ID,
                Birthday = person.BirthDay,
                Name = person.Name,
                CourseId = person.CourseID,
                Grade = person.Grade,
                NReg = person.NReg,
                Salary = person.Salary,
                Type = person.Type
            };
        }
    }
}
