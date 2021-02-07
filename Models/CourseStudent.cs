﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CourseStudent
    {
        public int CourseStudentID { get; set; }

        public Student Student { get; set; }

        public decimal Grade { get; set; }
    }
}
