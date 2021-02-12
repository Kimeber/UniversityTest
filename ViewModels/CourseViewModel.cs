using System;
using System.Collections.Generic;

namespace ViewModels
{
    public class CourseViewModel
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public decimal Credits { get; set; }

        public int DepartamentID { get; set; }

        public string Departament { get; set; }

        public List<SubjectViewModel> Subjects { get; set; }
    }
}
