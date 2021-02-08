﻿using System;
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

        public List<ClassStudentViewModel> Students { get; set; }
    }
}
