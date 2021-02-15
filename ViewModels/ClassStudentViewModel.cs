using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ClassStudentViewModel
    { 
        public int ClassStudentID { get; set; }

        public int StudentID { get; set; }

        public string Student { get; set; }

        public decimal? Grade { get; set; }
    }
}
