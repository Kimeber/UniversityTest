using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public Teacher Responsible { get; set; }

        public Departament Departament { get; set; }
    }
}
