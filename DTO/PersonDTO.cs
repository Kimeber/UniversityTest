using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataLayer;
using ViewModels;

namespace DTO
{
    public class PersonDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public DateTime? BirthDay { get; set; }

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
            return new PersonDTO
            {
                ID = person.Id,
                Name = person.Name,
                BirthDay = person.Birthday
            };
        }

        public static PersonDTO Map(PersonViewModel person)
        {
            return new PersonDTO
            {
                ID = person.Id,
                Name = person.Name,
                BirthDay = person.Birthday
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
            };
        }
    }
}
