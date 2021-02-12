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
                    .Where(x => x.Id == PersonID)
                    .SingleOrDefault();
                if (current == null)
                {
                    return null;
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
            using (ModelContainer context = new ModelContainer())
            {
                Person current = context.Person
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (current == null){
                    return false;
                }
                context.Person.Remove(current);
                context.SaveChanges();
                return true;
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
                Person old = context.Person
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (old == null)
                {
                    return false;
                }
                old.Name = person.Name;
                old.Birthday = person.BirthDay;
                context.SaveChanges();
                return true;
            }
        }
    }
}
