using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SubjectViewModel
    {
        public int SubjectID { get; set; }

        public int CourseID { get; set; }

        public int TeacherID { get; set; }

        public string Name { get; set; }

        public string Teacher { get; set; }

        public string Course { get; set; }

        public decimal Credits { get; set; }

        public decimal Average { get; set; }

        public List<ClassStudentViewModel> ClassStudents { get; set; }
    }
}
