using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityService
{
    public class DepartamentService
    {
        public static DepartamentDTO GetDepartament(int DepartamentID)
        {
            using(ModelContainer context = new ModelContainer())
            {
                Departament current = context.Departament
                    .Where(x => x.Id == DepartamentID)
                    .SingleOrDefault();
                if (current == null)
                {
                    return null;
                }
                return DepartamentDTO.Map(current);
            }
        }

        public static bool CreateDepartament(DepartamentDTO DepartamentDTO)
        {
            try
            {
                using (ModelContainer context = new ModelContainer())
                {
                    Departament Departament = DepartamentDTO.Map(DepartamentDTO);
                    context.Departament.Add(Departament);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteDepartament(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Departament current = context.Departament
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (current == null){
                    return false;
                }
                context.Departament.Remove(current);
                context.SaveChanges();
                return true;
            }
        }

        public static List<DepartamentDTO> GetAllDepartaments()
        {
            using (ModelContainer context = new ModelContainer())
            {
                List<DepartamentDTO> list = new List<DepartamentDTO>();
                var Departaments = context.Departament.ToList();
                foreach (Departament Departament in Departaments)
                {
                    list.Add(DepartamentDTO.Map(Departament));
                }
                return list;
            }
        }

        public static bool EditDepartament(int id, DepartamentDTO Departament)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Departament old = context.Departament
                    .Where(x => x.Id == id)
                    .SingleOrDefault();
                if (old == null)
                {
                    return false;
                }
                old.Name = Departament.Name;
                context.SaveChanges();
                return true;
            }
        }
    }
}
