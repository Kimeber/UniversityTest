using System;
using DataLayer;
using ViewModels;

namespace DTO
{
    public class DepartamentDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Teacher Director { get; set; }

        public static Departament Map(DepartamentDTO departamentDTO)
        {
            return new Departament
            {
                Id = departamentDTO.ID,
                Name = departamentDTO.Name
            };
        }

        public static DepartamentDTO Map(Departament departament)
        {
            return new DepartamentDTO
            {
                ID = departament.Id,
                Name = departament.Name
            };
        }

        public static DepartamentDTO Map(DepartamentViewModel departament)
        {
            return new DepartamentDTO
            {
                ID = departament.DepartmentID,
                Name = departament.Name
            };
        }

        public static DepartamentViewModel MapToView(DepartamentDTO departament)
        {
            if (departament == null)
            {
                return null;
            }
            return new DepartamentViewModel
            {
                DepartmentID = departament.ID,
                Name = departament.Name
            };
        }
    }
}
